using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKSystemAPI.Persistence.Configuration
{
    public static class Configurations
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configuration = new();
                configuration.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/EFKSystemAPI.BuildAPI"));
                configuration.AddJsonFile("appsettings.json");
                return configuration.GetConnectionString("PostgreSQL");
            }
        }
    }
}
