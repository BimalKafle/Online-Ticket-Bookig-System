using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Data.DataAccess
{
    public class DatabaseContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            AppConfiguration appConfig = new AppConfiguration();
            var OptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            OptionsBuilder.UseMySql(appConfig.MysqlConnectionString, appConfig.ServerVersion);
            return new ApplicationDbContext(OptionsBuilder.Options);
        }

        
    }
}
