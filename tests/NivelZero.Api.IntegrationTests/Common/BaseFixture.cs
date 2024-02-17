using Bogus;

namespace NivelZero.Api.IntegrationTests.Common;

public abstract class BaseFixture
{
    protected Faker Faker { get; } = new("pt_BR");
}