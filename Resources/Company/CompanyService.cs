using ApiBasic.Data;
using ApiBasic.Models;

namespace ApiBasic.Services;

public class CompanyService: BaseService<Company>
{
    private readonly AppDbContext _context;

    public CompanyService(AppDbContext context) : base(context)
    {
        _context = context;
    }
}