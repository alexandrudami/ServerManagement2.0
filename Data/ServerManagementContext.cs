using Microsoft.EntityFrameworkCore;
using BlazorSVM.Models;
namespace ServerManagement2._0.Data

{
    public class ServerManagementContext : DbContext
    {

        public ServerManagementContext(DbContextOptions<ServerManagementContext> options):base(options)
        {

        }

        public DbSet<Server> Servers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Server>()
                .HasData(
            new Server { ServerID = 1, Name = "Server1", City = "Toronto" },
            new Server { ServerID = 2, Name = "Server2", City = "Toronto" },
            new Server { ServerID = 3, Name = "Server3", City = "Toronto" },
            new Server { ServerID = 4, Name = "Server4", City = "Toronto" },
            new Server { ServerID = 5, Name = "Server5", City = "Montreal" },
            new Server { ServerID = 6, Name = "Server6", City = "Montreal" },
            new Server { ServerID = 7, Name = "Server7", City = "Montreal" },
            new Server { ServerID = 8, Name = "Server8", City = "Ottawa" },
            new Server { ServerID = 9, Name = "Server9", City = "Ottawa" },
            new Server { ServerID = 10, Name = "Server10", City = "Calgary" },
            new Server { ServerID = 11, Name = "Server11", City = "Calgary" },
            new Server { ServerID = 12, Name = "Server12", City = "Halifax" },
            new Server { ServerID = 13, Name = "Server13", City = "Halifax" }
            );
        }
    }
}
