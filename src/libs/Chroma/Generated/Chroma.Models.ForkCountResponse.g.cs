
#nullable enable

namespace Chroma
{
    /// <summary>
    /// Response containing the fork count for a collection.
    /// </summary>
    public sealed partial class ForkCountResponse
    {
        /// <summary>
        /// The number of forks for this collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ForkCountResponse" /> class.
        /// </summary>
        /// <param name="count">
        /// The number of forks for this collection.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ForkCountResponse(
            int count)
        {
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForkCountResponse" /> class.
        /// </summary>
        public ForkCountResponse()
        {
        }
    }
}