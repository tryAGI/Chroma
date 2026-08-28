/*
order: 70
title: Record metadata
slug: record-metadata
*/

using System.Text.Json;

namespace Chroma.IntegrationTests;

public partial class Tests
{
    //// Record metadata must use the generated HashMap type so source-generated
    //// JSON serialization can describe every value without reflection.

    [TestMethod]
    public void Example_RecordMetadata_SerializesWithSourceGeneration()
    {
        var request = new AddCollectionRecordsPayload
        {
            Embeddings = new EmbeddingsPayload(
                embeddingsPayloadVariant1: [[1.0f, 2.0f]],
                embeddingsPayloadVariant2: null),
            Ids = ["record-1"],
            Metadatas =
            [
                new HashMap
                {
                    AdditionalProperties = new Dictionary<string, object>
                    {
                        ["book"] = "Fahrenheit 451",
                        ["page"] = 112L,
                    },
                },
            ],
        };

        string json = request.ToJson();
        using JsonDocument document = JsonDocument.Parse(json);
        JsonElement metadata = document.RootElement.GetProperty("metadatas")[0];

        metadata.GetProperty("book").GetString().Should().Be("Fahrenheit 451");
        metadata.GetProperty("page").GetInt64().Should().Be(112L);
    }
}
