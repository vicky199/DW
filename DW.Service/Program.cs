using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace DW.Service
{
    class Program
    {
        private static IConfiguration _iconfiguration;
        public Program(IConfiguration iconfiguration)
        {
            _iconfiguration = iconfiguration;
        }

        public static void ConfigureServices()
        {
            var builder = new ConfigurationBuilder()
                      .SetBasePath(Directory.GetCurrentDirectory())
                      .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _iconfiguration = builder.Build();
            //var serviceProvider = new ServiceCollection()
            //    .
        }
        static void Main(string[] args)
        {
            ConfigureServices();
            Console.WriteLine("Hello World!");
        }
    }
}
