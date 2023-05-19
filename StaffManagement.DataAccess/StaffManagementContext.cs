using Microsoft.EntityFrameworkCore;
using StaffManagement.Core.Models;

namespace StaffManagement.DataAccess
{
    public class StaffManagementContext : DbContext
    {
        public StaffManagementContext(DbContextOptions<StaffManagementContext> options) : base(options)
        {
        }

        public DbSet<Staff> Staffs { get; set; }
    }
}