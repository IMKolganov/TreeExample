using AutoMapper;
using BusinessLayer.BusinessModels;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TreeExample.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class TreeController : ControllerBase
{
    private readonly IPermissionService _permissionService;
    private readonly IMapper _mapper;

    public TreeController( IPermissionService permissionService, IMapper mapper)
    {
        _permissionService = permissionService;
        _mapper = mapper;
    }

    
    
    [HttpGet]  
    public async Task<ActionResult<Permissions>> GetAllApplications()
    {
        var applications = await _permissionService.GetAllApplications();
        // var result = new ResponseObject
        // {
        //     Code = 1,
        //     Message = $"Get all applications", // TODO: Add messages
        //     Object = applications
        // };

        return Ok(applications);
    }
    
    // [HttpGet]
    // public async Task<ActionResult<ResponseObject>> GetUsersPermissionForApplication(int userId, int applicationId)
    // {
    //     var permissions = await _permissionService.GetUsersPermissions(userId, applicationId);
    //
    //     var result = new ResponseObject
    //     {
    //         Code = 1,
    //         Message = $"Get Permission for User with Id={userId} for Application with Id={applicationId}", // TODO: Add messages
    //         Object = permissions
    //     };
    //     return Ok(result);
    // }
}