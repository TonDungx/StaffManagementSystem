namespace StaffManagementSystem.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<Schedule> Schedules { get; set; }
        public List<PerformanceReview> PerformanceReviews { get; set; }
        public List<Leave> Leaves { get; set; }
        public List<ShiftSwap> ShiftSwaps { get; set; }
    }
}
