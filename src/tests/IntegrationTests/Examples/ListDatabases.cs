/*
order: 30
title: List Databases
slug: list-databases
*/

namespace Chroma.IntegrationTests;

public partial class Tests
{
    //// List all databases for the default Chroma tenant.

    [TestMethod]
    public async Task Example_ListDatabases()
    {
        var databases = await Client.Database.ListDatabasesAsync("default_tenant");

        databases.Should().ContainSingle();
        databases[0].Name.Should().Be("default_database");
        databases[0].Tenant.Should().Be("default_tenant");
    }
}
