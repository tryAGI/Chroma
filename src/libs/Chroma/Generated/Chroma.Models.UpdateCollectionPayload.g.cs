
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCollectionPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Chroma.JsonConverters.OneOfJsonConverter<object, global::Chroma.UpdateCollectionConfiguration>))]
        public global::Chroma.OneOf<object, global::Chroma.UpdateCollectionConfiguration>? NewConfiguration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_metadata")]
        public object? NewMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_name")]
        public string? NewName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCollectionPayload" /> class.
        /// </summary>
        /// <param name="newConfiguration"></param>
        /// <param name="newMetadata"></param>
        /// <param name="newName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCollectionPayload(
            global::Chroma.OneOf<object, global::Chroma.UpdateCollectionConfiguration>? newConfiguration,
            object? newMetadata,
            string? newName)
        {
            this.NewConfiguration = newConfiguration;
            this.NewMetadata = newMetadata;
            this.NewName = newName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCollectionPayload" /> class.
        /// </summary>
        public UpdateCollectionPayload()
        {
        }
    }
}