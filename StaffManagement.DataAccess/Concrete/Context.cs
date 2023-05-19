using Microsoft.EntityFrameworkCore;
using StaffManagement.Core.Models;

namespace StaffManagement.DataAccess.Concrete;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }
    
    public DbSet<Staff> Staffs { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.ApplyConfiguration(new StaffMap());
        base.OnModelCreating(modelBuilder);
    }
}