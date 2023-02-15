using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace ModelA.Samples;

[Area(ModelARemoteServiceConsts.ModuleName)]
[RemoteService(Name = ModelARemoteServiceConsts.RemoteServiceName)]
[Route("api/ModelA/sample")]
public class SampleController : ModelAController, ISampleAppService
{
    private readonly ISampleAppService _sampleAppService;

    public SampleController(ISampleAppService sampleAppService)
    {
        _sampleAppService = sampleAppService;
    }

    [HttpGet]
    public async Task<SampleDto> GetAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpGet]
    [Route("authorized")]
    [Authorize]
    public async Task<SampleDto> GetAuthorizedAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpGet]
    [Route("roles")]
    public async Task<List<string>> GetRolesAsync()
    {
        return await _sampleAppService.GetRolesAsync();
    }
}
