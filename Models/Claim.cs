using MonthlyClaim.Data;
using System.ComponentModel.DataAnnotations;

namespace MonthlyClaim.Models
{
    public class Claim
    {

        //Claims submission
        [Key]
        public int Id { get; set; }

        public String Logo { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Rate { get; set; }
    }
}
