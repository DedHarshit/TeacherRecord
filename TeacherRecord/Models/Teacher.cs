using System.ComponentModel.DataAnnotations;

namespace TeacherRecord.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Salary { get; set; }
    }
}
