using NivelZero.Domain.Companies;
using NivelZero.Domain.Tenants;
using NivelZero.Domain.UnitTests.Common;

namespace NivelZero.Domain.UnitTests.Tenants;

public class TenantTestFixture : BaseFixture
{
    public Tenant GenerateValidTenant()
    {
        return new Tenant(
            RandomValidName(),
            RandomValidMail(),
            RandomValidCompanyName(),
            RandomValidPhone(),
            RandomValidCompanySize(),
            RandomValidPrimaryInterest());
    }

    public string RandomValidName()
    {
        return Faker.Person.FullName;
    }

    public string RandomValidMail()
    {
        return Faker.Internet.Email();
    }

    public string RandomValidCompanyName()
    {
        return Faker.Company.CompanyName();
    }

    public string RandomValidPhone()
    {
        return Faker.Person.Phone;
    }

    public CompanySize RandomValidCompanySize()
    {
        return Faker.PickRandom<CompanySize>();
    }

    public PrimaryInterest RandomValidPrimaryInterest()
    {
        return Faker.PickRandom<PrimaryInterest>();
    }
}