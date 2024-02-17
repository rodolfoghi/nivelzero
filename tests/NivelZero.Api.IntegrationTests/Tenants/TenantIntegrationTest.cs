using FluentAssertions;
using NivelZero.Api.IntegrationTests.Common;
using System.Net;
using System.Net.Http.Json;

namespace NivelZero.Api.IntegrationTests.Tenants;

public class TenantIntegrationTest : BaseTest, IClassFixture<NivelZeroApiFactory<Program>>
{
    [Fact]
    public async Task ShouldCreateTenant()
    {
        // Arrange
        var createTenantRequest = _fixture.GetValidCreateTenantRequest();

        // Act
        var httpResponse = await httpClient.PostAsJsonAsync("/api/tenants", createTenantRequest);

        // Assert
        httpResponse.StatusCode.Should().Be(HttpStatusCode.Created);
    }

    private readonly TenantIntegrationTestFixture _fixture = new();

    public TenantIntegrationTest(NivelZeroApiFactory<Program> factory) : base(factory)
    {
    }
}