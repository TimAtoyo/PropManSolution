public class MaintenanceRequest
{
    public int Id { get; set; }
    public string Description { get; set; }
    public bool IsResolved { get; set; }
    public int TenantId { get; set; }
    public Tenant Tenant { get; set; }
}
