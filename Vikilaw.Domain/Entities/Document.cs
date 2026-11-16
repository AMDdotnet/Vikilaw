namespace Vikilaw.Domain.Entities;

public class Document : BaseEntity
{
    public int LawyerId { get; set; }
    public int MatterId { get; set; }
    public string OriginalFileName { get; set; } = null!;
    public string StorageKey { get; set; } = null!;
    public string ContentType { get; set; } = null!;
    public long SizeBytes { get; set; }
    public string Hash { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
