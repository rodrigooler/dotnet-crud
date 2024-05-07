using ApiBasic.Models;
using ApiBasic.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiBasic.Controllers;

[ApiController]
[Route("companies")]
public class CompanyController : BaseController<Company>
{
    private readonly CompanyService _service;

    public CompanyController(CompanyService service) : base(service)
    {
        _service = service;
    }
}