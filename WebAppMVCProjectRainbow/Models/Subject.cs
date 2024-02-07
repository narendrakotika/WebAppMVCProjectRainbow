using System.ComponentModel.DataAnnotations;

namespace WebAppMVCProjectRainbow.Models
{
    public class Subject
    {
        [Key]
        public int SubId { get; set; }
        public string? SubName { get; set; }
        public string? SubTeacher { get; set; }
        public int SubAuthor { get; set; }
    }
}
