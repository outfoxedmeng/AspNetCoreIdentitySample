using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Utils
{
    public static class ConfigurationHelper
    {
        public static IConfiguration Configuration { get; set; }
        public static string GetConfigValueByKey(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return string.Empty;
            }
            return Configuration[key];
        }
    }
}
