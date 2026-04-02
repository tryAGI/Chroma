#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Chroma
{
    /// <summary>
    /// Payload for deleting records from a collection.<br/>
    /// Records can be deleted by their IDs or by a metadata filter. At least one of `ids` or `where`<br/>
    /// must be provided.
    /// </summary>
    public readonly partial struct DeleteCollectionRecordsPayload : global::System.IEquatable<DeleteCollectionRecordsPayload>
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
        public global::Chroma.DeleteCollectionRecordsPayloadVariant2? DeleteCollectionRecordsPayloadVariant2 { get; init; }
#else
        public global::Chroma.DeleteCollectionRecordsPayloadVariant2? DeleteCollectionRecordsPayloadVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteCollectionRecordsPayloadVariant2))]
#endif
        public bool IsDeleteCollectionRecordsPayloadVariant2 => DeleteCollectionRecordsPayloadVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DeleteCollectionRecordsPayload(global::Chroma.RawWhereFields value) => new DeleteCollectionRecordsPayload((global::Chroma.RawWhereFields?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Chroma.RawWhereFields?(DeleteCollectionRecordsPayload @this) => @this.RawWhereFields;

        /// <summary>
        /// 
        /// </summary>
        public DeleteCollectionRecordsPayload(global::Chroma.RawWhereFields? value)
        {
            RawWhereFields = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DeleteCollectionRecordsPayload(global::Chroma.DeleteCollectionRecordsPayloadVariant2 value) => new DeleteCollectionRecordsPayload((global::Chroma.DeleteCollectionRecordsPayloadVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Chroma.DeleteCollectionRecordsPayloadVariant2?(DeleteCollectionRecordsPayload @this) => @this.DeleteCollectionRecordsPayloadVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DeleteCollectionRecordsPayload(global::Chroma.DeleteCollectionRecordsPayloadVariant2? value)
        {
            DeleteCollectionRecordsPayloadVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DeleteCollectionRecordsPayload(
            global::Chroma.RawWhereFields? rawWhereFields,
            global::Chroma.DeleteCollectionRecordsPayloadVariant2? deleteCollectionRecordsPayloadVariant2
            )
        {
            RawWhereFields = rawWhereFields;
            DeleteCollectionRecordsPayloadVariant2 = deleteCollectionRecordsPayloadVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DeleteCollectionRecordsPayloadVariant2 as object ??
            RawWhereFields as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RawWhereFields?.ToString() ??
            DeleteCollectionRecordsPayloadVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRawWhereFields && IsDeleteCollectionRecordsPayloadVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Chroma.RawWhereFields?, TResult>? rawWhereFields = null,
            global::System.Func<global::Chroma.DeleteCollectionRecordsPayloadVariant2?, TResult>? deleteCollectionRecordsPayloadVariant2 = null,
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
            else if (IsDeleteCollectionRecordsPayloadVariant2 && deleteCollectionRecordsPayloadVariant2 != null)
            {
                return deleteCollectionRecordsPayloadVariant2(DeleteCollectionRecordsPayloadVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Chroma.RawWhereFields?>? rawWhereFields = null,
            global::System.Action<global::Chroma.DeleteCollectionRecordsPayloadVariant2?>? deleteCollectionRecordsPayloadVariant2 = null,
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
            else if (IsDeleteCollectionRecordsPayloadVariant2)
            {
                deleteCollectionRecordsPayloadVariant2?.Invoke(DeleteCollectionRecordsPayloadVariant2!);
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
                DeleteCollectionRecordsPayloadVariant2,
                typeof(global::Chroma.DeleteCollectionRecordsPayloadVariant2),
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
        public bool Equals(DeleteCollectionRecordsPayload other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Chroma.RawWhereFields?>.Default.Equals(RawWhereFields, other.RawWhereFields) &&
                global::System.Collections.Generic.EqualityComparer<global::Chroma.DeleteCollectionRecordsPayloadVariant2?>.Default.Equals(DeleteCollectionRecordsPayloadVariant2, other.DeleteCollectionRecordsPayloadVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DeleteCollectionRecordsPayload obj1, DeleteCollectionRecordsPayload obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DeleteCollectionRecordsPayload>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DeleteCollectionRecordsPayload obj1, DeleteCollectionRecordsPayload obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DeleteCollectionRecordsPayload o && Equals(o);
        }
    }
}
