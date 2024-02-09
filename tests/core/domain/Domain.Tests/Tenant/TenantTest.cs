using Domain.Company;
using E = Domain.Tenant;

namespace Domain.Tests.Tenant;
public class TenantTest
{
    [Fact]
    public void ShouldCreateTenant()
    {
        // Arrange
        var tenantName = "TenantName";
        var tenantMail = "tenant@mail.com";
        var companyName = "My Company";
        var phone = "54999717396";
        var companySize = CompanySize.Small;
        var primaryInterest = E.PrimaryInterest.UseItInMyCompany;

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
