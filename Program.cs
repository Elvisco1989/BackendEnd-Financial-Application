using COPVETFinances.Data;
using COPVETFinances.Interfaces;
using COPVETFinances.Services;
using Microsoft.EntityFrameworkCore;

namespace COPVETFinances
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            builder.Services.AddDbContext<AppDBContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("conn")));

            builder.Services.AddTransient<IIncome,IncomeService >();
            builder.Services.AddTransient<IExpenditureService1, ExpenditureService>();
            builder.Services.AddTransient<IPlayer, PlayerService>();
            builder.Services.AddTransient<IStock, StockService>();
            builder.Services.AddTransient<IFamilyDaySevices, FamilyDaySevices>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}