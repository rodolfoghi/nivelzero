using NivelZero.Api.IntegrationTests.Common;
using NivelZero.Contracts.Tenants;
using NivelZero.Shared.Companies;
using NivelZero.Shared.Tenants;

namespace NivelZero.Api.IntegrationTests.Tenants;

public class TenantIntegrationTestFixture : BaseFixture
{
    public CreateTenantRequest GetValidCreateTenantRequest()
    {
        return new CreateTenantRequest(
            Faker.Person.FullName,
            Faker.Person.Email,
            Faker.Company.CompanyName(),
            Faker.Phone.PhoneNumber(),
            Faker.PickRandom<CompanySize>(),
            Faker.PickRandom<PrimaryInterest>()
        );
    }
}