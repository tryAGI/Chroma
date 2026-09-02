namespace Chroma;

/// <summary>
/// Builds a Chroma metadata filter by combining clauses with <c>$and</c>.
/// </summary>
public sealed class WhereFilter
{
    private bool _combineWithOr;
    private readonly global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, object?>> _clauses =
        new global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, object?>>();

    /// <summary>
    /// Gets the metadata clauses combined by this filter.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPropertyName("$and")]
    public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, object?>>? And =>
        _combineWithOr ? null : _clauses;

    /// <summary>
    /// Gets the metadata clauses when this filter combines them with <c>$or</c>.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPropertyName("$or")]
    public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, object?>>? OrClauses =>
        _combineWithOr ? _clauses : null;

    /// <summary>
    /// Combines clauses added directly to this filter with <c>$or</c> instead of <c>$and</c>.
    /// </summary>
    public WhereFilter Or()
    {
        _combineWithOr = true;
        return this;
    }

    /// <summary>
    /// Adds an equality clause.
    /// </summary>
    public WhereFilter Equals(string field, object? value) => Add(field, value);

    /// <summary>
    /// Adds an inequality clause.
    /// </summary>
    public WhereFilter NotEquals(string field, object? value) => AddComparison(field, "$ne", value);

    /// <summary>
    /// Adds a greater-than clause.
    /// </summary>
    public WhereFilter GreaterThan(string field, object value) => AddComparison(field, "$gt", value);

    /// <summary>
    /// Adds a greater-than-or-equal clause.
    /// </summary>
    public WhereFilter GreaterThanOrEqual(string field, object value) => AddComparison(field, "$gte", value);

    /// <summary>
    /// Adds a less-than clause.
    /// </summary>
    public WhereFilter LessThan(string field, object value) => AddComparison(field, "$lt", value);

    /// <summary>
    /// Adds a less-than-or-equal clause.
    /// </summary>
    public WhereFilter LessThanOrEqual(string field, object value) => AddComparison(field, "$lte", value);

    /// <summary>
    /// Adds a set-membership clause.
    /// </summary>
    public WhereFilter In(string field, global::System.Collections.Generic.IEnumerable<object> values) =>
        AddComparison(field, "$in", MaterializeValues(values, nameof(values)));

    /// <summary>
    /// Adds a negative set-membership clause.
    /// </summary>
    public WhereFilter NotIn(string field, global::System.Collections.Generic.IEnumerable<object> values) =>
        AddComparison(field, "$nin", MaterializeValues(values, nameof(values)));

    /// <summary>
    /// Adds a nested group whose filters are combined with <c>$and</c>.
    /// </summary>
    public WhereFilter All(params WhereFilter[] filters) => AddGroup("$and", filters);

    /// <summary>
    /// Adds a nested group whose filters are combined with <c>$or</c>.
    /// </summary>
    public WhereFilter Any(params WhereFilter[] filters) => AddGroup("$or", filters);

    /// <summary>
    /// Converts this filter to an AOT-safe JSON value accepted by <see cref="RawWhereFields.Where"/>.
    /// </summary>
    public global::System.Text.Json.JsonElement ToJsonElement()
    {
        if (_clauses.Count == 0)
        {
            throw new global::System.InvalidOperationException("At least one filter clause is required.");
        }

        if (_clauses.Count == 1)
        {
            return global::System.Text.Json.JsonSerializer.SerializeToElement(
                _clauses[0],
                WhereFilterJsonSerializerContext.Default.DictionaryStringObject);
        }

        return global::System.Text.Json.JsonSerializer.SerializeToElement(
            this,
            WhereFilterJsonSerializerContext.Default.WhereFilter);
    }

    private WhereFilter AddComparison(string field, string comparison, object? value) =>
        Add(field, new global::System.Collections.Generic.Dictionary<string, object?>
        {
            [comparison] = value,
        });

    private WhereFilter Add(string field, object? value)
    {
        global::System.ArgumentException.ThrowIfNullOrWhiteSpace(field);
        _clauses.Add(new global::System.Collections.Generic.Dictionary<string, object?>
        {
            [field] = value,
        });

        return this;
    }

    private WhereFilter AddGroup(string logicalOperator, WhereFilter[] filters)
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

    private WhereFilter AddValue(string operation, object value)
    {
        _clauses.Add(new global::System.Collections.Generic.Dictionary<string, object?>
        {
            [operation] = value,
        });

        return this;
    }

    private static global::System.Collections.Generic.List<object> MaterializeValues(
        global::System.Collections.Generic.IEnumerable<object> values,
        string parameterName)
    {
        global::System.ArgumentNullException.ThrowIfNull(values, parameterName);
        var materialized = values.ToList();
        if (materialized.Count == 0)
        {
            throw new global::System.ArgumentException("At least one value is required.", parameterName);
        }

        return materialized;
    }
}

[global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
    DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull)]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.WhereFilter))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.WhereFilter[]))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object?>))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Text.Json.JsonElement>))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
[global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
internal sealed partial class WhereFilterJsonSerializerContext : global::System.Text.Json.Serialization.JsonSerializerContext
{
}
