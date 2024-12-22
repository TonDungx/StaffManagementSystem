namespace StaffManagementSystem.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public DateTime ShiftDate { get; set; }
        public string ShiftType { get; set; } // Morning, Evening, Night
    }
}
