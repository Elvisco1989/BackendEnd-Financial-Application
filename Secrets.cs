using COPVETFinances.Migrations;
using Microsoft.AspNetCore.Hosting.Server;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace COPVETFinances
{
    //public class Secrets
    //{
    //    public static readonly string conn = "Data Source=copvetfinancesdbserver.database.windows.net;Initial Catalog=COPVETFinances_db;User ID=Mbah;Password=Elvisco1989;Connect Timeout=60;Trust Server Certificate=True";
    //}

    public class Secrets
    {
        public static readonly string conn = "Server = tcp:copvetfinancesdbserver.database.windows.net,1433;Initial Catalog = COPVETFinances_db; Persist Security Info=False;User ID = Mbah; Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30";
    }


}



