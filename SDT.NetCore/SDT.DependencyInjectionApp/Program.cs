using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SDT.DependencyInjectionApp
{
    public class Program
    {
        ///
        public static void Main(string[] args)
        {

            IHostBuilder hostBuilder = CreateHostBuilder(args);
            var host = hostBuilder.Build();
            host.Run();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            //����Ĭ������
            IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args); 
            //Ϊ���������������
            hostBuilder.ConfigureWebHostDefaults(webBuilder =>
            {
                //���һ��ע����������
                webBuilder.UseStartup<Startup>();
            });
            return hostBuilder;
        }

    }
}
