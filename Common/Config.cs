using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.IO;

namespace Common
{
    public static class Config
    {
        public static IConfiguration Configuration { 
            get {
                return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build(); 
            } 
        }

        public static IConfigurationSection GetKey(string key)
        {
            var sect = Configuration.GetSection(key);
            return sect;
        }
    }
}
