using NivelZero.Domain.Common;
using NivelZero.Shared.Companies;
using NivelZero.Shared.Tenants;

namespace NivelZero.Domain.Tenants;

public class Tenant(
    string name,
    string mail,
    string companyName,
    string phone,
    CompanySize companySize,
    PrimaryInterest primaryInterest) : BaseEntity
{
    public string Name { get; } = name;

    public string Mail { get; } = mail;

    public string CompanyName { get; } = companyName;

    public string Phone { get; } = phone;

    public CompanySize CompanySize { get; } = companySize;

    public PrimaryInterest PrimaryInterest { get; } = primaryInterest;
}