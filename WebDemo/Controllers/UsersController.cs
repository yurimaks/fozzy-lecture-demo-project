using Microsoft.AspNetCore.Mvc;

namespace WebDemo.Controllers;

[Route("users")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserRepository _userRepository;
    public UsersController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet]
    public ICollection<UserEntity> GetAll()
    {
        var users = _userRepository.GetAll();
        return users;
    }

    [HttpPost]
    public IActionResult Create([FromQuery] string name, [FromQuery] int age)
    {
        var users = _userRepository.AddUser(name, age);
        return Ok(users);
    }
}