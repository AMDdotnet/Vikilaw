namespace Vikilaw.Domain.Entities;

public class PushSubscription : BaseEntity
{
    public int LawyerId { get; set; }
    public string Endpoint { get; set; } = null!;
    public string P256DH { get; set; } = null!;
    public string Auth { get; set; } = null!;
    public bool IsActive { get; set; } = true;
    public DateTimeOffset? ExpiresAt { get; set; }
    public DateTimeOffset? LastUsedAt { get; set; }
}
