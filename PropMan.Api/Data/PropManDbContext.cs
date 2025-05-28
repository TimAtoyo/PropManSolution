using Microsoft.EntityFrameworkCore;

namespace PropMan.Api.Data;
    public class PropManDbContext : DbContext
    {
        public PropManDbContext(DbContextOptions<PropManDbContext> options)
            : base(options){}
        public DbSet<Property> Properties { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<MaintenanceRequest> MaintenanceRequests { get; set; }
    }
