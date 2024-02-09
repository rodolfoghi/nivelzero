using Bogus;

namespace Domain.Tests.Common;
public abstract class BaseTest
{
    protected Faker Faker { get; } = new();
}
