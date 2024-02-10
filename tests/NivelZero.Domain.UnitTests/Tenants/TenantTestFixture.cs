using NivelZero.Domain.Companies;
using NivelZero.Domain.Tenants;
using NivelZero.Domain.UnitTests.Common;

namespace NivelZero.Domain.UnitTests.Tenants;

public class TenantTestFixture : BaseFixture
{
   public Domain.Tenants.Tenant GenerateValidTenant() => new(
        RandomValidName(),
        RandomValidMail(),
        RandomValidCompanyName(),
        RandomValidPhone(),
        RandomValidCompanySize(),
        RandomValidPrimaryInterest());
   
    public string RandomValidName() => Faker.Person.FullName;
    public string RandomValidMail() => Faker.Internet.Email();
    public string RandomValidCompanyName() => Faker.Company.CompanyName();
    public string RandomValidPhone() => Faker.Person.Phone;
    public CompanySize RandomValidCompanySize() => Faker.PickRandom<CompanySize>();
    public PrimaryInterest RandomValidPrimaryInterest() => Faker.PickRandom<PrimaryInterest>();
}