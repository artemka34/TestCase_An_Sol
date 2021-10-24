using System;
using System.Threading;
using System.Threading.Tasks;
using Domain.Departments;
using Domain.Employees;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public interface IEfContext : IDisposable
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default (CancellationToken));
    }
}