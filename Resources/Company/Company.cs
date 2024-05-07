using System.ComponentModel.DataAnnotations;

namespace ApiBasic.Models;

public class Company : Base
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
}