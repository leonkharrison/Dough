using Dough.Data;
using Dough.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dough.Services.IncomeService
{
    public class IncomeService : BaseService<Income>, IIncomeService
    {
        public IncomeService( DoughDbContext doughDbContext ) : base( doughDbContext )
        {
        }
    }
}
