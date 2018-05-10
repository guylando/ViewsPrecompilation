using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace A
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var application = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
            application.Run();
        }
    }
}
