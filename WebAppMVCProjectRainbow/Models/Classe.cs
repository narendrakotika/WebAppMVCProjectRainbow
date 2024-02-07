using System.ComponentModel.DataAnnotations;

namespace WebAppMVCProjectRainbow.Models
{
    public class Classe
    {
        [Key]
        public int CId { get; set; }
        public string? CName  { get; set; }
        public double CStrength { get; set; }
        public string? CTeacherName { get; set; }



    }
}
