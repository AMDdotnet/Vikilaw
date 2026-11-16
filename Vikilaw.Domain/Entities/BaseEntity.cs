namespace Vikilaw.Domain.Entities;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public bool IsDelete { get; set; } = false;
    public DateTimeOffset? DeletedAt { get; set; }
}
