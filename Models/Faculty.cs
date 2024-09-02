using System.ComponentModel.DataAnnotations;

namespace MonthlyClaim.Models
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }

        public String Logo { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
    }
}
