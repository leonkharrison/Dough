using Dough.Data;
using Dough.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dough.Services.BankAccountService
{
    public class BankAccountService : BaseService<BankAccount>, IBankAccountService
    {
        public BankAccountService( DoughDbContext doughDbContext ) : base( doughDbContext ) { }
    }
}
