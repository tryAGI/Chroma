using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

if (args.Length == 0)
{
    throw new ArgumentException("Expected the path to an OpenAPI JSON or YAML file.");
}

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

if (string.IsNullOrWhiteSpace(yamlOrJson))
{
    throw new InvalidOperationException($"OpenAPI document '{path}' is empty.");
}

OpenApiDocument openApiDocument;

try
{
    openApiDocument = yamlOrJson.GetOpenApiDocument(Settings.Default);
}
catch (Exception ex)
{
    var preview = yamlOrJson[..Math.Min(yamlOrJson.Length, 200)].ReplaceLineEndings(" ");
    throw new InvalidOperationException(
        $"Failed to parse OpenAPI document '{path}'. Ensure the source returns valid JSON or YAML. File starts with: {preview}",
        ex);
}

yamlOrJson = await openApiDocument.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_2);

await File.WriteAllTextAsync(path, yamlOrJson);
