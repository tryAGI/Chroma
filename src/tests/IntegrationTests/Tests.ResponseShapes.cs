namespace Chroma.IntegrationTests;

/// <summary>
/// Calls that exist to prove the generated models can read what the server actually sends.
/// </summary>
/// <remarks>
/// The generated deserializers enforce <c>required</c>, so a field the server omits turns a
/// successful HTTP 200 into a <c>JsonException</c>. Elsewhere in the workspace this went unnoticed
/// until a probe hit the surface: Anthropic's `caller`, Label Studio's `username`, and Qdrant's
/// `peer_id` all failed on successful responses with nothing exercising them.
///
/// These run against the Testcontainers instance, so they cost nothing and need no key. The schemas
/// with the deepest required lists here - `AttachedFunctionApiResponse` at nine fields and
/// `AttachedFunctionInfo` - have no response that names them directly, so they stay uncovered until
/// something attaches a function.
/// </remarks>
public partial class Tests
{
    private const string DefaultTenant = "default_tenant";
    private const string DefaultDatabase = "default_database";

    [TestMethod]
    public async Task UserIdentity_Deserializes()
    {
        // GetUserIdentityResponse: user_id, tenant, databases
        var identity = await Client.Authentication.GetUserIdentityAsync();

        identity.Should().NotBeNull();
        identity.Tenant.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task PreFlightChecks_Deserializes()
    {
        var checks = await Client.System.PreFlightChecksAsync();

        checks.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Tenant_Deserializes()
    {
        var tenant = await Client.Tenant.GetTenantAsync(DefaultTenant);

        tenant.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Database_Deserializes()
    {
        // Database: id, name, tenant
        var database = await Client.Database.GetDatabaseAsync(
            database: DefaultDatabase,
            tenant: DefaultTenant);

        database.Should().NotBeNull();
        database.Name.Should().Be(DefaultDatabase);
    }
}
