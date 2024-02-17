using NivelZero.Application.Common;
using NivelZero.Contracts.Tenants;

namespace NivelZero.Application.Tenants;

public interface ITenantAppService : IAppService
{
    Task<CreateTenantResponse> CreateTenantAsync(CreateTenantRequest request);

    Task<CreateTenantResponse?> GetTenantAsync(Guid id);
}