using StaffManagement.Core.Repositories;
using System;
using StaffManagement.Core.Models;
using StaffManagement.DataAccess.Repositories;

namespace StaffManagement.DataAccess
{
    public class UnitOfWork : IDisposable
    {
        private readonly StaffManagementContext _context;
        private IGenericRepository<Staff> _staffRepository;

        public UnitOfWork(StaffManagementContext context)
        {
            _context = context;
        }

        public IGenericRepository<Staff> StaffRepository
        {
            get
            {
                return _staffRepository = _staffRepository ?? new GenericRepository<Staff>(_context);
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}