using System;
using System.Configuration;

namespace OrangeHRM.Tools
{
    public static class RunConfiguration
    {
        public static string Browser => ReadConfig("Browser");
        public static string Url => ReadConfig("Url");
        public static string Username => ReadConfig("User");
        public static string Password => ReadConfig("Password");

        private static string ReadConfig(string key) => Environment.GetEnvironmentVariable(key) ?? ConfigurationManager.AppSettings[key];
    }
}
