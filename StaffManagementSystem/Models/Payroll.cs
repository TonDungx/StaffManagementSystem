namespace StaffManagementSystem.Models
{
    public class Payroll
    {
        public int Id { get; set; } // Mã bảng lương
        public int EmployeeId { get; set; } // Mã nhân viên (khóa ngoại)
        public Employee Employee { get; set; } // Thông tin nhân viên
        public decimal BaseSalary { get; set; } // Lương cơ bản
        public decimal Bonus { get; set; } // Thưởng
        public decimal Deductions { get; set; } // Khấu trừ (thuế, bảo hiểm, v.v...)
        
        // Tổng lương sẽ được tính tự động từ lương cơ bản, thưởng và khấu trừ
        public decimal NetSalary => BaseSalary + Bonus - Deductions; 
    }
}
