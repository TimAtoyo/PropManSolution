public class Tenant
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public int PropertyId { get; set; }
    public Property Property { get; set; }
}
