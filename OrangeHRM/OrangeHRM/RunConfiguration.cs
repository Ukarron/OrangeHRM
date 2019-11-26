using System;
using System.Configuration;

namespace OrangeHRM
{
    public static class RunConfiguration
    {
        public static string Browser => ReadConfig("Browser");
        public static string Url => ReadConfig("Url");

        private static string ReadConfig(string key) => Environment.GetEnvironmentVariable(key) ?? ConfigurationManager.AppSettings[key];
    }
}
