using Vikilaw.Domain.Enums;

namespace Vikilaw.Domain.Entities;

public class Reminder : BaseEntity
{
    public int LawyerId { get; set; }
    public int EventId { get; set; }
    public DateTimeOffset TriggerAt { get; set; }
    public ReminderStatus Status { get; set; }
    public DateTimeOffset? ProcessedAt { get; set; }
}
