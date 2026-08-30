namespace Chroma;

/// <summary>
/// Builds a Chroma metadata filter by combining clauses with <c>$and</c>.
/// </summary>
public sealed class WhereFilter
{
    /// <summary>
    /// Gets the metadata clauses combined by this filter.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPropertyName("$and")]
    public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, object?>> And { get; } =
        new global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, object?>>();

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
        AddComparison(field, "$in", values?.ToList() ?? throw new global::System.ArgumentNullException(nameof(values)));

    /// <summary>
    /// Adds a negative set-membership clause.
    /// </summary>
    public WhereFilter NotIn(string field, global::System.Collections.Generic.IEnumerable<object> values) =>
        AddComparison(field, "$nin", values?.ToList() ?? throw new global::System.ArgumentNullException(nameof(values)));

    /// <summary>
    /// Converts this filter to an AOT-safe JSON value accepted by <see cref="RawWhereFields.Where"/>.
    /// </summary>
    public global::System.Text.Json.JsonElement ToJsonElement() =>
        global::System.Text.Json.JsonSerializer.SerializeToElement(
            this,
            WhereFilterJsonSerializerContext.Default.WhereFilter);

    private WhereFilter AddComparison(string field, string comparison, object? value) =>
        Add(field, new global::System.Collections.Generic.Dictionary<string, object?>
        {
            [comparison] = value,
        });

    private WhereFilter Add(string field, object? value)
    {
        global::System.ArgumentException.ThrowIfNullOrWhiteSpace(field);
        And.Add(new global::System.Collections.Generic.Dictionary<string, object?>
        {
            [field] = value,
        });

        return this;
    }
}

[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Chroma.WhereFilter))]
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
