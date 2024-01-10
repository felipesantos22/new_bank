using crud.Application.Services.Validations;
using crud.Domain.Dtos;
using crud.Domain.Entities;
using crud.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers;
[Route("api/deposity")]
[ApiController]
public class DeposityController : ControllerBase
{

    private readonly DeposityRepository _deposityRepository;
    private readonly UserFk _userFk;

    public DeposityController(DeposityRepository deposityRepository, UserFk userFk)
    {
        _deposityRepository = deposityRepository;
        _userFk = userFk;
    }

    [HttpPost]
    public async Task<ActionResult<Deposity>> Create([FromBody] Deposity deposity)
    {
        var userFk = _userFk.ExistsUserFk(deposity.UserId);
        if (!userFk)
        {
            return BadRequest(new { message = "User not found" });
        }
        var newDeposits = await _deposityRepository.Create(deposity);
        return Ok(newDeposits);
    }
    
    [HttpGet]
    public async Task<ActionResult<DeposityDto>> Index()
    {
        var deposits = await _deposityRepository.Index();
        return Ok(deposits);
    }
    
}