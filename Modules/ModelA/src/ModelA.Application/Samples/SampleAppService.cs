using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Identity;

namespace ModelA.Samples;

public class SampleAppService : ModelAAppService, ISampleAppService
{
    private readonly IIdentityRoleRepository _identityRoleRepository;

    public SampleAppService(IIdentityRoleRepository identityRoleRepository)
    {
        _identityRoleRepository = identityRoleRepository;
    }

    public async Task<List<string>> GetRolesAsync()
    {
        var roles = await _identityRoleRepository.GetListAsync();
        return roles.Select(x => x.Name).ToList();
    }

    public Task<SampleDto> GetAsync()
    {
        return Task.FromResult(
            new SampleDto
            {
                Value = 42
            }
        );
    }

    [Authorize]
    public Task<SampleDto> GetAuthorizedAsync()
    {
        return Task.FromResult(
            new SampleDto
            {
                Value = 42
            }
        );
    }
}
