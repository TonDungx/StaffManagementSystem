namespace StaffManagementSystem.Models
{
    public class PerformanceReview
    {
        public int Id { get; set; } // Mã đánh giá
        public int EmployeeId { get; set; } // Mã nhân viên (khóa ngoại)
        public Employee Employee { get; set; } // Thông tin nhân viên
        public string Review { get; set; } // Đánh giá hiệu suất của nhân viên
        public DateTime ReviewDate { get; set; } // Ngày đánh giá
        public string Reviewer { get; set; } // Người đánh giá (có thể là quản lý)
    }
}
