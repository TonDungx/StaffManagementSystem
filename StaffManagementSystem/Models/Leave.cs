namespace StaffManagementSystem.Models
{
    public class Leave
    {
        public int Id { get; set; } // Mã nghỉ phép
        public int EmployeeId { get; set; } // Mã nhân viên (khóa ngoại)
        public Employee Employee { get; set; } // Thông tin nhân viên
        public DateTime LeaveStartDate { get; set; } // Ngày bắt đầu nghỉ
        public DateTime LeaveEndDate { get; set; } // Ngày kết thúc nghỉ
        public string LeaveType { get; set; } // Loại nghỉ phép (ví dụ: nghỉ phép năm, nghỉ bệnh, v.v...)
        public bool IsApproved { get; set; } // Trạng thái phê duyệt (true nếu được phê duyệt, false nếu chưa)
    }
}
