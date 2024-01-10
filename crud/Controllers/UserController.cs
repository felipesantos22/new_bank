using crud.Application.Services.Validations;
using crud.Domain.Entities;
using crud.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers;

[Route("api/user")]
[ApiController]
public class UserController: ControllerBase
{
    private readonly UserRepository _userRepository;

    public UserController(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpPost]
    public async Task<ActionResult<User>> Create([FromBody] User user)
    {
        
        var newUser = await _userRepository.Create(user);
        return Ok(newUser);
    }
    
    [HttpGet]
    public async Task<ActionResult<List<User>>> Index()
    {
        var users = await _userRepository.Index();

        var responseList = users.Select(user => new
        {
            User = user,
            TotalValue = user.Deposities.Sum(deposit => deposit.Value)
        }).ToList();

        return Ok(responseList);
    }
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult<User>> Show(int id)
    {
        var user = await _userRepository.Show(id);
        if (user == null)
        {
            return NotFound(new { message = "User not found." });
        }

        var response = new
        {
            User = user,
            DepositsSum = user.Deposities.Sum(v => v.Value)
        };
        
        return Ok(response);
    }
}