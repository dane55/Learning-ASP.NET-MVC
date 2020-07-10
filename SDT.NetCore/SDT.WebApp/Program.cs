using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SDT.WebApp
{
    public class Program
    {
        /// <summary>
        /// 1��ASP.NET CORE ��������Դ�����
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //����������һ��IHostBuilder �������
            IHostBuilder hostBuilder = CreateHostBuilder(args);
            //���𴴽�IHost
            IHost host = hostBuilder.Build();
            //����IHost
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            //����Ĭ�ϵ�ͨ������Host������
            IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args);
            //����ͨ��������Ĭ������
            hostBuilder.ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
            return hostBuilder;
        }

    }
}
