using Vikilaw.Domain.Enums;

namespace Vikilaw.Domain.Entities;

public class MatterEvent : BaseEntity
{
    public int LawyerId { get; set; }
    public int MatterId { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = string.Empty;
    public EventType Type { get; set; }
    public EventStatus Status { get; set; }
    public DateTimeOffset StartAt { get; set; }
    public DateTimeOffset? EndAt { get; set; }
    public string TimeZoneId { get; set; } = "UTC";
    public string Location { get; set; } = string.Empty;
    public DateTimeOffset? UpdateAt { get; set; }
}
