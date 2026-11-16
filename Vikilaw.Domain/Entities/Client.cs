namespace Vikilaw.Domain.Entities;

public class Client : BaseEntity
{
    public int LawyerId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string NationalId { get; set; } = null!;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
    public DateTimeOffset? UpdateAt { get; set; }
    public DateTimeOffset? ArchivedAt { get; set; }
}
