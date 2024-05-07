using ApiBasic.Data;
using ApiBasic.Models;

namespace ApiBasic.Services;

public class UserService : BaseService<User>
{
    private readonly AppDbContext _context;

    public UserService(AppDbContext context) : base(context) {
        _context = context;
    }

    // public User[] GetByRole(Role role)
    // {
    //     return _context.Users.Where(u => u.Role == role).ToArray();
    // }

    // public User[] GetByStatus(Status status)
    // {
    //     return _context.Users.Where(u => u.Status == status).ToArray();
    // }
}
