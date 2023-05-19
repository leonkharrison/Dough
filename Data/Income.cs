using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dough.Data
{
    public class Income : BaseEntity
    {
        public double Amount { get; set; }
        public DateTime PayDate { get; set; }
        public bool AllowWeekendPayDate { get; set; }

        public int BankAccountId { get; set; }
        public virtual BankAccount BankAccount { get; set; }
    }
}
