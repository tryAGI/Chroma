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

    [TestMethod]
    public void Example_WhereFilter_SerializesOrAndNestedGroups()
    {
        var where = new WhereFilter()
            .Equals("published", true)
            .Any(
                new WhereFilter().Equals("language", "en"),
                new WhereFilter().Equals("language", "fr"));

        JsonElement root = where.ToJsonElement();
        JsonElement clauses = root.GetProperty("$and");

        clauses.GetArrayLength().Should().Be(2);
        JsonElement alternatives = clauses[1].GetProperty("$or");
        alternatives.GetArrayLength().Should().Be(2);
        alternatives[0].GetProperty("language").GetString().Should().Be("en");
        alternatives[1].GetProperty("language").GetString().Should().Be("fr");
    }

    [TestMethod]
    public void Example_WhereFilter_SerializesRootOr()
    {
        JsonElement root = new WhereFilter()
            .Or()
            .Equals("category", "books")
            .Equals("category", "articles")
            .ToJsonElement();

        root.TryGetProperty("$and", out _).Should().BeFalse();
        root.GetProperty("$or").GetArrayLength().Should().Be(2);
    }

    [TestMethod]
    public void Example_WhereFilter_FlattensSingleClauseRegardlessOfLogicalMode()
    {
        JsonElement root = new WhereFilter()
            .Or()
            .Equals("category", "books")
            .ToJsonElement();

        root.GetProperty("category").GetString().Should().Be("books");
        root.TryGetProperty("$and", out _).Should().BeFalse();
        root.TryGetProperty("$or", out _).Should().BeFalse();
    }

    [TestMethod]
    public void Example_WhereFilter_RejectsEmptyValueAndFilterGroups()
    {
        var filter = new WhereFilter();

        var inAction = () => filter.In("language", []);
        var groupAction = () => filter.Any();

        inAction.Should().Throw<ArgumentException>();
        groupAction.Should().Throw<ArgumentException>();
    }
}
