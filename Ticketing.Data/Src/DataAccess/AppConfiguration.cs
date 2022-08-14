

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Data.DataAccess
{
    public class AppConfiguration
    {
        public AppConfiguration()
        {
            ServerVersion = new MySqlServerVersion(new Version(15, 1, 0));
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");

            configurationBuilder.AddJsonFile(path);
            var root = configurationBuilder.Build();
            var appSetting = root.GetSection("ConnectionStrings:DefaultConnection");
            MysqlConnectionString = appSetting.Value;
        }
        public string MysqlConnectionString { get; set; }
        public MySqlServerVersion ServerVersion { get; set; }
    }
}
