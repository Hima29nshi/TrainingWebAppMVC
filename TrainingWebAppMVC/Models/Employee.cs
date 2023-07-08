using System.ComponentModel.DataAnnotations;

namespace TrainingWebAppMVC.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Employee ID is required")]
        public int? EmpId { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Salary is required")]
        public double? Salary { get; set; }
    }
}
