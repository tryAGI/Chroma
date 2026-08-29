/*
order: 75
title: Metadata filters
slug: metadata-filters
*/

using System.Text.Json;

namespace Chroma.IntegrationTests;

public partial class Tests
{
    //// Metadata filters can be combined with IDs, include fields, pagination,
    //// and other get options in one request payload.

    [TestMethod]
    public void Example_WhereFilter_SerializesCombinedGetPayload()
    {
        var where = new WhereFilter()
            .Equals("category", "Botanic books")
            .GreaterThan("page", 10)
            .In("language", ["en", "fr"]);
        var request = new GetRequestPayload(
            rawWhereFields: new RawWhereFields
            {
                Where = where.ToJsonElement(),
            },
            getRequestPayloadVariant2: new GetRequestPayloadVariant2
            {
                Ids = ["record-1"],
                Include = [Include.Documents],
                Limit = 10,
                Offset = 0,
            });

        string json = request.ToJson();
        using JsonDocument document = JsonDocument.Parse(json);
        JsonElement root = document.RootElement;

        root.GetProperty("ids")[0].GetString().Should().Be("record-1");
        root.GetProperty("include")[0].GetString().Should().Be("documents");
        root.GetProperty("limit").GetInt32().Should().Be(10);
        JsonElement clauses = root.GetProperty("where").GetProperty("$and");
        clauses.GetArrayLength().Should().Be(3);
        clauses[0].GetProperty("category").GetString().Should().Be("Botanic books");
        clauses[1].GetProperty("page").GetProperty("$gt").GetInt32().Should().Be(10);
        clauses[2].GetProperty("language").GetProperty("$in").GetArrayLength().Should().Be(2);
    }
}
