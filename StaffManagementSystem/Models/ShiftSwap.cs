namespace StaffManagementSystem.Models
{
    public class ShiftSwap
    {
        public int Id { get; set; } // Mã yêu cầu hoán đổi ca
        public int EmployeeId { get; set; } // Mã nhân viên yêu cầu (khóa ngoại)
        public Employee Employee { get; set; } // Thông tin nhân viên yêu cầu
        public int RequestedShiftId { get; set; } // Mã ca làm việc yêu cầu
        public int ProposedShiftId { get; set; } // Mã ca làm việc thay thế
        public bool IsApproved { get; set; } // Trạng thái phê duyệt (true nếu được phê duyệt, false nếu không)
        public DateTime RequestDate { get; set; } // Ngày yêu cầu hoán đổi ca
    }
}
