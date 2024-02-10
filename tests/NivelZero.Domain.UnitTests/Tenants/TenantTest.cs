using FluentAssertions;
using E = NivelZero.Domain.Tenants;

namespace NivelZero.Domain.UnitTests.Tenants;

public class TenantTest
{
    private readonly TenantTestFixture _fixture = new();
    
    [Fact]
    public void ShouldCreateTenant()
    {
        // Arrange
        var tenantName = _fixture.RandomValidName();
        var tenantMail = _fixture.RandomValidMail();
        var companyName = _fixture.RandomValidCompanyName();
        var phone = _fixture.RandomValidPhone();
        var companySize = _fixture.RandomValidCompanySize();
        var primaryInterest = _fixture.RandomValidPrimaryInterest();
        var dateBeforeCreate = DateTime.Now;

        // Act
        E.Tenant tenant = new(tenantName, tenantMail, companyName, phone, companySize, primaryInterest);

        // Assert
        tenant.Should().NotBeNull();
        tenant.Name.Should().Be(tenantName);
        tenant.Mail.Should().Be(tenantMail);
        tenant.CompanyName.Should().Be(companyName);
        tenant.Phone.Should().Be(phone);
        tenant.CompanySize.Should().Be(companySize);
        tenant.PrimaryInterest.Should().Be(primaryInterest);
        tenant.Id.Should().NotBe(default(Guid));
        tenant.CreatedAt.Should().BeOnOrAfter(dateBeforeCreate);
    }
}
