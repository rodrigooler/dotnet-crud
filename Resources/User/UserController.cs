namespace ApiBasic.Controllers;

using Microsoft.AspNetCore.Mvc;
using ApiBasic.Services;
using ApiBasic.Models;
using System.Collections;

[ApiController]
[Route("users")]
public class UserController : BaseController<User>
{
    private readonly UserService _service;

    public UserController(UserService service) : base(service)
    {
        _service = service;
    }
}