using Dough.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dough.Database
{
    public class DoughDbContext : DbContext
    {
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Outgoing> Outgoings { get; set; }
        public DbSet<Income> Incomes { get; set; }

        public string DbPath { get; }

        public DoughDbContext( )
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath( folder );
            DbPath = Path.Join( path, "dough.db" );
        }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            base.OnConfiguring( optionsBuilder );

            optionsBuilder.UseSqlite( $"Data Source={DbPath}" );
        }

    }
}
