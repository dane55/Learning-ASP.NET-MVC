using System;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Logging.Debug;
using Microsoft.Extensions.Options;

namespace SDT.Web
{

    /// <summary>
    /// ����һ���յ�ASP.NET Core3.1��Web����Ŀ������4���ļ�
    ///  <para>1��<see cref = "Program" />.cs</para>
    ///  <para>2��<see cref = "Startup" />.cs</para>
    ///  <para>3��appsettings.json</para>
    ///  <para>4��appsettings.Development.json</para>
    ///  <para>���벢�ɹ����п�Web��Ŀ����bin/debug�ļ��п���Ҳֻ��һ��SDT.Web��DLL�ļ��Լ���ص�json�ļ�����һ��Webϵͳ̫����������</para>
    /// <para></para>
    /// 
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
        }

    }
}
