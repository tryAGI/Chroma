
#nullable enable

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_name")]
        public string? NewName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_metadata")]
        public object? NewMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCollection" /> class.
        /// </summary>
        /// <param name="newName"></param>
        /// <param name="newMetadata"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateCollection(
            string? newName,
            object? newMetadata)
        {
            this.NewName = newName;
            this.NewMetadata = newMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCollection" /> class.
        /// </summary>
        public UpdateCollection()
        {
        }
    }
}