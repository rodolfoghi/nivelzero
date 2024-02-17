using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace NivelZero.Api.IntegrationTests.Common;

public abstract class BaseTest
{
    private readonly NivelZeroApiFactory<Program> _factory;
    protected readonly HttpClient httpClient;

    protected BaseTest(NivelZeroApiFactory<Program> factory)
    {
        _factory = factory;
        httpClient = _factory.CreateClient(new WebApplicationFactoryClientOptions
        {
            AllowAutoRedirect = false,
        });
    }
}