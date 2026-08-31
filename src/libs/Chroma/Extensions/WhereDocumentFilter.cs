using System.Text.RegularExpressions;

namespace Chroma;

/// <summary>
/// Builds a Chroma document-content filter.
/// </summary>
public sealed class WhereDocumentFilter
{
    private bool _combineWithOr;
    private readonly global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, object?>> _clauses = [];

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
    /// Matches documents containing <paramref name="searchText"/>.
    /// </summary>
    public WhereDocumentFilter Contains(string searchText) => Add("$contains", searchText);

    /// <summary>
    /// Matches documents that do not contain <paramref name="searchText"/>.
    /// </summary>
    public WhereDocumentFilter NotContains(string searchText) => Add("$not_contains", searchText);

    /// <summary>
    /// Matches documents satisfying <paramref name="regex"/>.
    /// </summary>
    public WhereDocumentFilter Regex(Regex regex)
    {
        global::System.ArgumentNullException.ThrowIfNull(regex);
        return Regex(regex.ToString());
    }

    /// <summary>
    /// Matches documents satisfying <paramref name="pattern"/>.
    /// </summary>
    public WhereDocumentFilter Regex(string pattern) => Add("$regex", pattern);

    /// <summary>
    /// Matches documents that do not satisfy <paramref name="regex"/>.
    /// </summary>
    public WhereDocumentFilter NotRegex(Regex regex)
    {
        global::System.ArgumentNullException.ThrowIfNull(regex);
        return NotRegex(regex.ToString());
    }

    /// <summary>
    /// Matches documents that do not satisfy <paramref name="pattern"/>.
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
    /// Converts this filter to an AOT-safe JSON value accepted by <see cref="RawWhereFields.WhereDocument"/>.
    /// </summary>
    public global::System.Text.Json.JsonElement ToJsonElement()
    {
        if (_clauses.Count == 0)
        {
            throw new global::System.InvalidOperationException("At least one document filter clause is required.");
        }

        if (_clauses.Count == 1 && !_combineWithOr)
        {
            return global::System.Text.Json.JsonSerializer.SerializeToElement(
                _clauses[0],
                WhereDocumentFilterJsonSerializerContext.Default.DictionaryStringObject);
        }

        return global::System.Text.Json.JsonSerializer.SerializeToElement(
            this,
            WhereDocumentFilterJsonSerializerContext.Default.WhereDocumentFilter);
    }

    private WhereDocumentFilter Add(string operation, string value)
    {
        global::System.ArgumentException.ThrowIfNullOrWhiteSpace(value);
        _clauses.Add(new global::System.Collections.Generic.Dictionary<string, object?>
        {
            [operation] = value,
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

        return AddValue(logicalOperator, filters.Select(static filter => filter.ToJsonElement()).ToList());
    }

    private WhereDocumentFilter AddValue(string operation, object value)
    {
        _clauses.Add(new global::System.Collections.Generic.Dictionary<string, object?>
        {
            [operation] = value,
        });

        return this;
    }
}

[global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
    DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.WhereDocumentFilter))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object?>))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Text.Json.JsonElement>))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
internal sealed partial class WhereDocumentFilterJsonSerializerContext : global::System.Text.Json.Serialization.JsonSerializerContext
{
}
