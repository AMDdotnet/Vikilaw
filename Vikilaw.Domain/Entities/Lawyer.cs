namespace Vikilaw.Domain.Entities;

public class Lawyer : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = null!;
    public string TimeZoneId { get; set; } = "UTC";
    public bool IsActive { get; set; } = true;
}
