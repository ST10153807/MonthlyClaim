using System.Data.Entity;

namespace MonthlyClaim.Data
{
    public class ClaimsDb : DbContext
    {
        public ClaimsDb(DbContext<ClaimsDb> options) : base(options) { }
        {
        }
    }
}
