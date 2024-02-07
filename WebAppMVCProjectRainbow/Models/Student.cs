using System.ComponentModel.DataAnnotations;

namespace WebAppMVCProjectRainbow.Models
{
    public class Student
    {
        [Key]
        public int SId { get; set; }
        public string? FName { get; set; }
        public string?  LName { get; set; }
        public int SAge { get; set; }
    }
}
