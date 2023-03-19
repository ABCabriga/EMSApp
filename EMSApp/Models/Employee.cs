using System.ComponentModel.DataAnnotations;

namespace EMSApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public int? DepartmentID { get; set; }
        public Department? Departments { get; set; }


    }
}
