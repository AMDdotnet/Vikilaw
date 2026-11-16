namespace Vikilaw.Domain.Entities;

public class MatterClient
{
    public int LawyerId { get; set; }
    public int MatterId { get; set; }
    public int ClientId { get; set; }
    public string RoleInMatter { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
}
