using NivelZero.Contracts.Tenants;

namespace NivelZero.Application.Tenants;

public class TenantAppService : ITenantAppService
{
    public Task<CreateTenantResponse> CreateTenantAsync(CreateTenantRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<CreateTenantResponse?> GetTenantAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> CommitAsync()
    {
        throw new NotImplementedException();
    }
}