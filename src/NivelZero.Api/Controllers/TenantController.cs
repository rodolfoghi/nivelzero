using Microsoft.AspNetCore.Mvc;
using NivelZero.Application.Tenants;
using NivelZero.Contracts.Tenants;

namespace NivelZero.API.Controllers;

public class TenantController(ITenantAppService tenantAppService) : ApiController
{
    [HttpPost]
    [ProducesResponseType<CreateTenantResponse>(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<CreateTenantResponse>> CreateTenant(CreateTenantRequest request)
    {
        var response = await tenantAppService.CreateTenantAsync(request);

        return CreatedAtAction(
            nameof(GetTenant),
            new { id = response.Id },
            response);
    }

    [HttpGet("{id:guid}")]
    [ProducesResponseType<CreateTenantResponse>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<CreateTenantResponse>> GetTenant(Guid id)
    {
        var tenant = await tenantAppService.GetTenantAsync(id);

        if (tenant is null) return NotFound();

        return tenant;
    }
}