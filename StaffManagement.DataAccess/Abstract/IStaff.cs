using StaffManagement.Core.Models;

namespace StaffManagement.DataAccess.Abstract;

public interface IStaff : IRepository<Staff>
{
    List<Staff> GetStaffByAge(int age);
}