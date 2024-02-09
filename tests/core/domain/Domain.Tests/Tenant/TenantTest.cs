using Domain.Company;
using Domain.Tests.Common;
using E = Domain.Tenant;

namespace Domain.Tests.Tenant;

public class TenantTest : BaseTest
{
    [Fact]
    public void ShouldCreateTenant()
    {
        // Arrange
        var tenantName = Faker.Person.FullName;
        var tenantMail = Faker.Internet.Email();
        var companyName = Faker.Company.CompanyName();
        var phone = Faker.Person.Phone;
        var companySize = Faker.PickRandom<CompanySize>();
        var primaryInterest = Faker.PickRandom<E.PrimaryInterest>();

        // Act
        E.Tenant tenant = new(tenantName, tenantMail, companyName, phone, companySize, primaryInterest);

        // Assert
        Assert.Equal(tenantName, tenant.Name);
        Assert.Equal(tenantMail, tenant.Mail);
        Assert.Equal(companyName, tenant.CompanyName);
        Assert.Equal(phone, tenant.Phone);
        Assert.Equal(companySize, tenant.CompanySize);
        Assert.Equal(primaryInterest, tenant.PrimaryInterest);
    }
}
