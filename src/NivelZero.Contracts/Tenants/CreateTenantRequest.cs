using NivelZero.Shared.Companies;
using NivelZero.Shared.Tenants;

namespace NivelZero.Contracts.Tenants;

public record CreateTenantRequest(
    string Name,
    string Mail,
    string CompanyName,
    string Phone,
    CompanySize CompanySize,
    PrimaryInterest PrimaryInterest);