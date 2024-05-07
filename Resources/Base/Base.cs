namespace ApiBasic.Models;

public enum Status
{
    Active,
    Inactive,
    Blocked,
    Deleted,
}

public class Base
{
    public int Id { get; set; }

    public Status Status { get; set; } = Status.Active;

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}