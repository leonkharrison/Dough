using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dough.Data
{
    public class BaseEntity
    {
        [Key]
        [Browsable( false )]
        public int Id { get; set; }
        [Browsable( false )]
        public DateTime CreatedAt { get; set; }
        [Browsable( false )]
        public DateTime LastModifiedAt { get; set; }
    }
}
