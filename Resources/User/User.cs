using System.ComponentModel.DataAnnotations;

namespace ApiBasic.Models;

public enum Role
{
    Admin,
    User
}

public class User : Base
{
    [MinLength(3)]
    [MaxLength(100)]
    public required string Name { get; set; }

    [EmailAddress]
    [MaxLength(254)]
    public required string Email { get; set; }

    [Phone]
    [MaxLength(20)]
    public required string Phone { get; set; }

    [MinLength(6)]
    [MaxLength(100)]
    public required string Password { get; set; }

    // [EnumDataType(typeof(Role))]
    // public Role[] Roles { get; set; } = { Role.User };
}