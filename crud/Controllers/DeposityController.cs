using crud.Domain.Entities;
using crud.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers;
[Route("api/deposity")]
[ApiController]
public class DeposityController : ControllerBase
{

    private readonly DeposityRepository _deposityRepository;

    public DeposityController(DeposityRepository deposityRepository)
    {
        _deposityRepository = deposityRepository;
    }

    [HttpPost]
    public async Task<ActionResult<Deposity>> Create([FromBody] Deposity deposity)
    {
        var newDeposits = await _deposityRepository.Create(deposity);
        return Ok(newDeposits);
    }
    
    [HttpGet]
    public async Task<ActionResult<Deposity>> Index()
    {
        var deposits = await _deposityRepository.Index();
        return Ok(deposits);
    }
    
}