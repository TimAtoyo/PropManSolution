public class Property
{
    public int Id { get; set; }
    public string Address { get; set; }
    public decimal RentAmount { get; set; }
    public List<Tenant> Tenants { get; set; } = new();
}
