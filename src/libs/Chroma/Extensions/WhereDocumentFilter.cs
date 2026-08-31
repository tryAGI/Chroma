using System.Text.RegularExpressions;

namespace Chroma;

// https://docs.trychroma.com/docs/querying-collections/full-text-search
// We support full-text search with the $contains and $not_contains operators.
// We also support regular expression pattern matching with the $regex and $not_regex operators.
// You can also use the logical operators $and and $or to combine multiple filters.
// .get and .query can handle where_document search combined with metadata filtering:

/*
 * Python doc
 
collection.get(
   where_document={"$contains": "search string"}
) 

collection.get(
   where_document={
       "$regex": "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
   }
)

collection.query(
    query_texts=["query1", "query2"],
    where_document={
        "$and": [
            {"$contains": "search_string_1"},
            {"$regex": "[a-z]+"},
        ]
    }
)

collection.query(
    query_texts=["query1", "query2"],
    where_document={
        "$or": [
            {"$contains": "search_string_1"},
            {"$not_contains": "search_string_2"},
        ]
    }
)

collection.query(
    query_texts=["doc10", "thus spake zarathustra", ...],
    n_results=10,
    where={"metadata_field": "is_equal_to_this"},
    where_document={"$contains":"search_string"}
)
*/

/// <summary>
/// Builds a Chroma document filter by combining clauses with <c>$and</c>.
/// </summary>
public sealed class WhereDocumentFilter
{
    private bool _combineWithOr;
    private readonly global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, object?>> _clauses =
        new global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, object?>>();

    /// <summary>
    /// Gets the document clauses combined by this filter.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPropertyName("$and")]
    public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, object?>>? And =>
        _combineWithOr ? null : _clauses;

    /// <summary>
    /// Gets the document clauses when this filter combines them with <c>$or</c>.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPropertyName("$or")]
    public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, object?>>? OrClauses =>
        _combineWithOr ? _clauses : null;

    /// <summary>
    /// Combines clauses added directly to this filter with <c>$or</c> instead of <c>$and</c>.
    /// </summary>
    public WhereDocumentFilter Or()
    {
        _combineWithOr = true;
        return this;
    }

    /// <summary>
    /// Adds an equality clause.
    /// </summary>
    public WhereDocumentFilter Contains(string searchString) => Add("$contains", searchString);

    /// <summary>
    /// Adds an inequality clause.
    /// </summary>
    public WhereDocumentFilter NotContains(string searchString) => Add("$not_contains", searchString);

    /// <summary>
    /// Adds a greater-than clause.
    /// </summary>
    public WhereDocumentFilter Regex(Regex regex) => Add("$regex", regex?.ToString());

    /// <summary>
    /// Adds a greater-than-or-equal clause.
    /// </summary>
    public WhereDocumentFilter Regex(string pattern) => Add("$regex", pattern);

    /// <summary>
    /// Adds a less-than clause.
    /// </summary>
    public WhereDocumentFilter NotRegex(Regex regex) => Add("$not_regex", regex?.ToString());

    /// <summary>
    /// Adds a less-than-or-equal clause.
    /// </summary>
    public WhereDocumentFilter NotRegex(string pattern) => Add("$not_regex", pattern);

    /// <summary>
    /// Adds a nested group whose filters are combined with <c>$and</c>.
    /// </summary>
    public WhereDocumentFilter All(params WhereDocumentFilter[] filters) => AddGroup("$and", filters);

    /// <summary>
    /// Adds a nested group whose filters are combined with <c>$or</c>.
    /// </summary>
    public WhereDocumentFilter Any(params WhereDocumentFilter[] filters) => AddGroup("$or", filters);

    /// <summary>
    /// Converts this filter to an AOT-safe JSON value accepted by <see cref="RawWhereFields.Where"/>.
    /// </summary>
    public global::System.Text.Json.JsonElement ToJsonElement() =>
        global::System.Text.Json.JsonSerializer.SerializeToElement(
            this,
            WhereDocumentFilterJsonSerializerContext.Default.WhereDocumentFilter);

    private WhereDocumentFilter Add(string field, object? value)
    {
        global::System.ArgumentException.ThrowIfNullOrWhiteSpace(field);
        _clauses.Add(new global::System.Collections.Generic.Dictionary<string, object?>
        {
            [field] = value,
        });

        return this;
    }

    private WhereDocumentFilter AddGroup(string logicalOperator, WhereDocumentFilter[] filters)
    {
        global::System.ArgumentNullException.ThrowIfNull(filters);
        if (filters.Length == 0)
        {
            throw new global::System.ArgumentException("At least one filter is required.", nameof(filters));
        }
        if (global::System.Array.Exists(filters, static filter => filter is null))
        {
            throw new global::System.ArgumentException("Filters cannot contain null values.", nameof(filters));
        }

        return Add(logicalOperator, filters);
    }
}

[global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
    DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.WhereDocumentFilter))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.WhereDocumentFilter[]))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
internal sealed partial class WhereDocumentFilterJsonSerializerContext : global::System.Text.Json.Serialization.JsonSerializerContext
{
}
