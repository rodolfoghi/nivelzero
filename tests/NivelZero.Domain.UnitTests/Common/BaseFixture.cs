using Bogus;

namespace NivelZero.Domain.UnitTests.Common;
public abstract class BaseFixture
{
    protected Faker Faker { get; } = new();
}
