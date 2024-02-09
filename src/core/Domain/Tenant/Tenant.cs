using Domain.Company;

namespace Domain.Tenant;
public class Tenant(
    string name,
    string mail,
    string companyName,
    string phone,
    CompanySize companySize,
    PrimaryInterest primaryInterest)
{
    public string Name { get; } = name;
    public string Mail { get; } = mail;
    public string CompanyName { get; } = companyName;
    public string Phone { get; } = phone;
    public CompanySize CompanySize { get; } = companySize;
    public PrimaryInterest PrimaryInterest { get; } = primaryInterest;
}
