using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dough.Data
{
    public class PermanentEntity : BaseEntity
    {

        [Browsable( false )]
        public bool IsDeleted { get; set; }
    }
}
