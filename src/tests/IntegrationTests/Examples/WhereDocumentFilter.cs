/*
order: 76
title: Document filters
slug: document-filters
*/

using System.Text.Json;
using System.Text.RegularExpressions;

namespace Chroma.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_WhereDocumentFilter_SerializesSingleClause()
    {
        JsonElement root = new WhereDocumentFilter()
            .Contains("machine learning")
            .ToJsonElement();

        root.GetProperty("$contains").GetString().Should().Be("machine learning");
    }

    [TestMethod]
    public void Example_WhereDocumentFilter_SerializesLogicalGroups()
    {
        JsonElement root = new WhereDocumentFilter()
            .Contains("sdk")
            .Any(
                new WhereDocumentFilter().Regex(new Regex("[a-z]+")),
                new WhereDocumentFilter().NotContains("deprecated"))
            .ToJsonElement();

        JsonElement clauses = root.GetProperty("$and");
        clauses.GetArrayLength().Should().Be(2);
        clauses[0].GetProperty("$contains").GetString().Should().Be("sdk");
        JsonElement alternatives = clauses[1].GetProperty("$or");
        alternatives[0].GetProperty("$regex").GetString().Should().Be("[a-z]+");
        alternatives[1].GetProperty("$not_contains").GetString().Should().Be("deprecated");
    }

    [TestMethod]
    public void Example_WhereDocumentFilter_SerializesInRequestPayload()
    {
        var request = new GetRequestPayload(
            rawWhereFields: new RawWhereFields
            {
                WhereDocument = new WhereDocumentFilter().NotRegex("^draft").ToJsonElement(),
            },
            getRequestPayloadVariant2: new GetRequestPayloadVariant2());

        using JsonDocument document = JsonDocument.Parse(request.ToJson());
        document.RootElement
            .GetProperty("where_document")
            .GetProperty("$not_regex")
            .GetString()
            .Should().Be("^draft");
    }

    [TestMethod]
    public void Example_WhereDocumentFilter_RejectsInvalidInput()
    {
        var filter = new WhereDocumentFilter();

        var emptyValueAction = () => filter.Contains(" ");
        var emptyGroupAction = () => filter.All();
        var emptyFilterAction = () => filter.ToJsonElement();

        emptyValueAction.Should().Throw<ArgumentException>();
        emptyGroupAction.Should().Throw<ArgumentException>();
        emptyFilterAction.Should().Throw<InvalidOperationException>();
    }
}
