using Vikilaw.Domain.Enums;

namespace Vikilaw.Domain.Entities;

public class Matter : BaseEntity
{
    public int LawyerId { get; set; }
    public int InternalNumber { get; set; }
    public int CourtCaseNumber { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public MatterStatus Status { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTimeOffset? UpdateAt { get; set; }
    public DateTimeOffset? ClosedAt { get; set; }
}
