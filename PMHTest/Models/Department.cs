using System.ComponentModel.DataAnnotations;

namespace PMHTest.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Display(Name = "Отдел")]
        public string DepartmentName { get; set; } = string.Empty;

        public List<Employee>? Employees { get; set; }
    }
}
