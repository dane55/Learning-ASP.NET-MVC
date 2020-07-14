using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace SDT.WebApp
{
    /// <summary>
    /// <see cref="Startup"/>�����������������ܵ�������Ӧ����Ҫ�ķ���
    /// </summary>
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        /// <summary>
        /// Asp.Net Core�Դ�������ע������<see cref="IServiceCollection"/>
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            //Session�ǻ��ڷֲ�ʽ���洴���ģ�������Session֮ǰҪ������DistributedCache
            services.AddDistributedMemoryCache();
            services.AddSession((options => options.IdleTimeout = TimeSpan.FromSeconds(10)));
        }

        /// <summary>
        ///  ���������м��
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }
            //Ĭ���ĵ����������ļ��е�ʱ�򽫼��������ļ���default.htm��default.html��index.htm��index.html
            app.UseDefaultFiles();
            //�������Ϊ��Ȩ�޷���wwwroot�µľ�̬��Դ�ļ�
            app.UseStaticFiles();
            //·���м��
            app.UseRouting();
            //
            app.UseAuthentication();
            //
            app.UseAuthorization();
            //
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
