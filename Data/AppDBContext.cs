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
        public DbSet<ExpenditureFamilyDay> ExpenditureFamilyDays { get; set; }
        public DbSet<Party> Party1 { get; set; }
        public DbSet<Contribution> Contributions { get; set; }

        public DbSet<PartIncome> PartyIncomes { get; set; }

        public DbSet<DrinksExpenses> Drinks { get; set; }
        public DbSet<FoodExpenses> Foods { get; set; }
        public DbSet<SportExpenses> Sports { get; set; }
        public DbSet<HallAndLogistics> Hall { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the mapping for the ExpenditureFamilyDay entity
            modelBuilder.Entity<ExpenditureFamilyDay>(entity =>
            {
                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18,2)"); // Adjust precision and scale as per your requirements
            });
        }
        public DbSet<COPVETFinances.Model.DrinksExpenses> DrinksExpenses { get; set; } = default!;
        public DbSet<COPVETFinances.Model.HallAndLogistics> HallAndLogistics { get; set; } = default!;
        public DbSet<COPVETFinances.Model.FoodExpenses> FoodExpenses { get; set; } = default!;
        public DbSet<COPVETFinances.Model.SportExpenses> SportExpenses { get; set; } = default!;
    }

    

    
}
