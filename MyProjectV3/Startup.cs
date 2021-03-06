using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ClassLibrary.Interfaces.SQLInterfaces.ISQLServices;
using ClassLibrary.Infrastructure;
using ClassLibrary.Interfaces;
using ClassLibrary.Interfaces.SQLInterfaces;
using ClassLibrary.Repositories.SQL_Repositories;
using ClassLibrary.Service.SQL_Services;
using ClassLibrary.UOW;
using ClassLibrary.Interfaces.SQLInterfaces.ISQLRepositories;

namespace MyProjectV3
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            #region SQL repositories
            services.AddTransient<ISQLOrderRepository, SQLOrderRepository>();
            services.AddTransient<ISQLUserRepository, SQLUserRepository>();
            services.AddTransient<ISQLProductTypeRepository, SQLProductTypeRepository>();
            services.AddTransient<ISQLProductRepository, SQLProductRepository>();
            #endregion  

            #region SQL services
            services.AddTransient<ISQLUserService, SQLUserService>();
            services.AddTransient<ISQLOrderService, SQLOrderService>();
            services.AddTransient<ISQLProductTypeService, SQLProductTypeService>();
            services.AddTransient<ISQLProductsService, SQLProductService>();
            #endregion

            services.AddTransient<ISQLUnitOfWork, UnitOfWork>();

            services.AddTransient<IConnectionFactory, ConnectionFactory>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
