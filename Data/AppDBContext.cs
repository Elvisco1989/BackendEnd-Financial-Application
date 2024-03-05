using COPVETFinances.Interfaces;
using COPVETFinances.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace COPVETFinances.Data
{
    public class AppDBContext: DbContext
    {
        public AppDBContext()
        {

        }
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        { 

        }

        

        public  DbSet<Expenditure> Expenditures { get; set; }

        public  DbSet<Income> Income { get; set; }

        public  DbSet<Player> Players { get; set; }

        public DbSet<Stock> Stocks { get; set; }
    }

    

    
}
