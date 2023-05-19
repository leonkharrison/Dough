using Dough.Data;
using Dough.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dough.Services.OutgoingService
{
    public class OutgoingService : BaseService<Outgoing>, IOutgoingService
    {
        public OutgoingService( DoughDbContext doughDbContext ) : base( doughDbContext )
        {
        }
    }
}
