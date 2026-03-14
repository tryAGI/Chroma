
#nullable enable

namespace Chroma
{
    /// <summary>
    /// Schema representation for collection index configurations<br/>
    /// This represents the server-side schema structure used for index management
    /// </summary>
    public sealed partial class Schema3
    {
        /// <summary>
        /// Customer-managed encryption key for collection data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmek")]
        public object? Cmek { get; set; }

        /// <summary>
        /// Default index configurations for each value type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaults")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Chroma.ValueTypes Defaults { get; set; }

        /// <summary>
        /// Key-specific index overrides<br/>
        /// TODO(Sanket): Needed for backwards compatibility. Should remove after deploy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Chroma.ValueTypes> Keys { get; set; }

        /// <summary>
        /// ID of the attached function that created this output collection (if applicable)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_attached_function_id")]
        public string? SourceAttachedFunctionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Schema3" /> class.
        /// </summary>
        /// <param name="cmek">
        /// Customer-managed encryption key for collection data
        /// </param>
        /// <param name="defaults">
        /// Default index configurations for each value type
        /// </param>
        /// <param name="keys">
        /// Key-specific index overrides<br/>
        /// TODO(Sanket): Needed for backwards compatibility. Should remove after deploy.
        /// </param>
        /// <param name="sourceAttachedFunctionId">
        /// ID of the attached function that created this output collection (if applicable)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Schema3(
            global::Chroma.ValueTypes defaults,
            global::System.Collections.Generic.Dictionary<string, global::Chroma.ValueTypes> keys,
            object? cmek,
            string? sourceAttachedFunctionId)
        {
            this.Defaults = defaults ?? throw new global::System.ArgumentNullException(nameof(defaults));
            this.Keys = keys ?? throw new global::System.ArgumentNullException(nameof(keys));
            this.Cmek = cmek;
            this.SourceAttachedFunctionId = sourceAttachedFunctionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Schema3" /> class.
        /// </summary>
        public Schema3()
        {
        }
    }
}