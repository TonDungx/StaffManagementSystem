using Microsoft.EntityFrameworkCore;
using StaffManagementSystem.Models; // Đảm bảo đã có namespace của các models

namespace StaffManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor để truyền các tùy chọn cho DbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Các DbSet đại diện cho các bảng trong cơ sở dữ liệu
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<PerformanceReview> PerformanceReviews { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<ShiftSwap> ShiftSwaps { get; set; }
    }
}
