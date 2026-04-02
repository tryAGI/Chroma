#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct QueryRequestPayload : global::System.IEquatable<QueryRequestPayload>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Chroma.RawWhereFields? RawWhereFields { get; init; }
#else
        public global::Chroma.RawWhereFields? RawWhereFields { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RawWhereFields))]
#endif
        public bool IsRawWhereFields => RawWhereFields != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Chroma.QueryRequestPayloadVariant2? QueryRequestPayloadVariant2 { get; init; }
#else
        public global::Chroma.QueryRequestPayloadVariant2? QueryRequestPayloadVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(QueryRequestPayloadVariant2))]
#endif
        public bool IsQueryRequestPayloadVariant2 => QueryRequestPayloadVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryRequestPayload(global::Chroma.RawWhereFields value) => new QueryRequestPayload((global::Chroma.RawWhereFields?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Chroma.RawWhereFields?(QueryRequestPayload @this) => @this.RawWhereFields;

        /// <summary>
        /// 
        /// </summary>
        public QueryRequestPayload(global::Chroma.RawWhereFields? value)
        {
            RawWhereFields = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryRequestPayload(global::Chroma.QueryRequestPayloadVariant2 value) => new QueryRequestPayload((global::Chroma.QueryRequestPayloadVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Chroma.QueryRequestPayloadVariant2?(QueryRequestPayload @this) => @this.QueryRequestPayloadVariant2;

        /// <summary>
        /// 
        /// </summary>
        public QueryRequestPayload(global::Chroma.QueryRequestPayloadVariant2? value)
        {
            QueryRequestPayloadVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public QueryRequestPayload(
            global::Chroma.RawWhereFields? rawWhereFields,
            global::Chroma.QueryRequestPayloadVariant2? queryRequestPayloadVariant2
            )
        {
            RawWhereFields = rawWhereFields;
            QueryRequestPayloadVariant2 = queryRequestPayloadVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            QueryRequestPayloadVariant2 as object ??
            RawWhereFields as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RawWhereFields?.ToString() ??
            QueryRequestPayloadVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRawWhereFields && IsQueryRequestPayloadVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Chroma.RawWhereFields?, TResult>? rawWhereFields = null,
            global::System.Func<global::Chroma.QueryRequestPayloadVariant2?, TResult>? queryRequestPayloadVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRawWhereFields && rawWhereFields != null)
            {
                return rawWhereFields(RawWhereFields!);
            }
            else if (IsQueryRequestPayloadVariant2 && queryRequestPayloadVariant2 != null)
            {
                return queryRequestPayloadVariant2(QueryRequestPayloadVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Chroma.RawWhereFields?>? rawWhereFields = null,
            global::System.Action<global::Chroma.QueryRequestPayloadVariant2?>? queryRequestPayloadVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRawWhereFields)
            {
                rawWhereFields?.Invoke(RawWhereFields!);
            }
            else if (IsQueryRequestPayloadVariant2)
            {
                queryRequestPayloadVariant2?.Invoke(QueryRequestPayloadVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RawWhereFields,
                typeof(global::Chroma.RawWhereFields),
                QueryRequestPayloadVariant2,
                typeof(global::Chroma.QueryRequestPayloadVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(QueryRequestPayload other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Chroma.RawWhereFields?>.Default.Equals(RawWhereFields, other.RawWhereFields) &&
                global::System.Collections.Generic.EqualityComparer<global::Chroma.QueryRequestPayloadVariant2?>.Default.Equals(QueryRequestPayloadVariant2, other.QueryRequestPayloadVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(QueryRequestPayload obj1, QueryRequestPayload obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<QueryRequestPayload>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(QueryRequestPayload obj1, QueryRequestPayload obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is QueryRequestPayload o && Equals(o);
        }
    }
}
