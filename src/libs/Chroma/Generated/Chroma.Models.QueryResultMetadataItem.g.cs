
#nullable enable

namespace Chroma
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryResultMetadataItem
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResultMetadataItem" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public QueryResultMetadataItem(
 )
        {
        }
    }
}