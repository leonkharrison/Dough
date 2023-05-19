using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dough.Data
{
    public class BankAccount : PermanentEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double TotalOut { get; set; }
    }
}
