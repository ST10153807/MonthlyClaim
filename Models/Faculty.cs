using MonthlyClaim.Data;
using System.ComponentModel.DataAnnotations;

namespace MonthlyClaim.Models
{
    public class Faculty
    {
        //Lecturer
        [Key]
        public int Id { get; set; }

        public String Logo { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Subject Subject { get; set; }
    }
}
