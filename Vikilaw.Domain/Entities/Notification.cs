using Vikilaw.Domain.Enums;

namespace Vikilaw.Domain.Entities;

public class Notification : BaseEntity
{
    public int LawyerId { get; set; }
    public int ReminderId { get; set; }
    public string Title { get; set; } = null!;
    public string Message { get; set; } = null!;
    public bool IsActive { get; set; } = true;
    public DateTimeOffset? ReadAt { get; set; }
    public DateTimeOffset? InAppCreated { get; set; }
    public PushDeliveryStatus PushStatus { get; set; }
    public DateTimeOffset? PushSentAt { get; set; }
    public string? PushLastError { get; set; }
}
