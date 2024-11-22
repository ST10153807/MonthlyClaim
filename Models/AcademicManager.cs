using MonthlyClaim.Data;
using System.ComponentModel.DataAnnotations;

namespace MonthlyClaim.Models
{
    public class AcademicManager
    {
        //Academic Manager
        [Key]
        public int Id { get; set; }

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Title { get; set; }
        public Department Department { get; set; }
    }
}
