using Microsoft.OpenApi;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var text = await File.ReadAllTextAsync(path);

text = text
        .Replace("openapi: 3.1.0", "openapi: 3.0.1")
        .Replace("\"openapi\": \"3.1.0\"", "\"openapi\": \"3.0.1\"")
    ;

var openApiDocument = new OpenApiStringReader().Read(text, out var diagnostics);

var endPoint = openApiDocument.Paths["/api/v1/collections/{collection_id}"];
openApiDocument.Paths.Remove("/api/v1/collections/{collection_id}");
openApiDocument.Paths["/api/v1/collections/{collection_name}"].Operations.Add(OperationType.Put, endPoint.Operations[OperationType.Put]);
openApiDocument.Paths["/api/v1/collections/{collection_name}"].Operations[OperationType.Put].Parameters[0].Name = "collection_name";

openApiDocument.Servers.Add(new OpenApiServer { Url = "http://localhost:8080" });

//openApiDocument.Components.Schemas["GenerateCompletionRequest"]!.Properties["stream"]!.Default = new OpenApiBoolean(true);

text = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(text, out diagnostics);

if (diagnostics.Errors.Count > 0 && diagnostics.Errors.Any(x => !x.Message.StartsWith("The path signature")))
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, text);
return;