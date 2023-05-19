using Microsoft.EntityFrameworkCore;
using StaffManagement.Core.Models;
using StaffManagement.DataAccess.Abstract;
using StaffManagement.DataAccess.Concrete;

namespace StaffManagement.DataAccess.EntityFramework;

public class StaffEntityFramework : Repository<Staff>, IStaff
{
    private readonly DbContextOptions<Context> _options;
    
    public StaffEntityFramework(DbContextOptions<Context> options) : base()
    {
        _options = options;
    }
    
    public List<Staff> GetStaffByAge(int age)
    {
        using var context = new Context(_options);
        return context.Staffs.Where(x => x.DateOfBirth.Year == DateTime.Now.Year - age).ToList();
    }
}

public class Repository<T>
{
}