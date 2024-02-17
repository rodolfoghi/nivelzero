using Microsoft.AspNetCore.Mvc.Testing;

namespace NivelZero.Api.IntegrationTests.Common;

public class NivelZeroApiFactory<TProgram>
    : WebApplicationFactory<TProgram> where TProgram : class
{
}