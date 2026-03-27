using System.ComponentModel.DataAnnotations;

namespace PMHTest.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Отдел")]
        public int DepartmentId { get; set; }

        [Required]
        [Display(Name = "ФИО")]
        [RegularExpression(@"^[A-Za-zА-Яа-яЁё]+(\s+[A-Za-zА-Яа-яЁё]+)+$", ErrorMessage = "Введите ФИО полностью")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Номер телефона")]
        [RegularExpression(@"^\+?\d{11}$", ErrorMessage = "Некорректный номер телефона")]
        public string PhoneNumber { get; set; } = string.Empty;

        public string? PhotoPath { get; set; }

        public Department? Department { get; set; }
    }
}
