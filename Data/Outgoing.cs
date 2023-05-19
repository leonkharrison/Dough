using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dough.Data
{
    public class Outgoing : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime PayOnDate { get; set; }
        public bool Reoccuring { get; set; }
        public bool AllowWeekendPayDate { get; set; }

        [Browsable( false )]
        public int BankAccountId { get; set; }
        public virtual BankAccount BankAccount { get; set; }
    }
}
