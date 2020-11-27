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
using VeiculosAPI2.DAO;
using VeiculosAPI2.Business;

namespace VeiculosAPI2
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
            
            services.AddSwaggerDocument();
            services.AddControllers();
            services.AddSingleton<ICarroDAO, CarroDAO>();
            services.AddSingleton<ICaminhaoDAO, CaminhaoDAO>();
            services.AddSingleton<IMotoDAO, MotoDAO>();
            services.AddSingleton<ICarroBusiness, CarroBusiness>();
            services.AddSingleton<ICaminhaoBusiness, CaminhaoBusiness>();
            services.AddSingleton<IMotoBusiness, MotoBusiness>();
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
            
            app.UseOpenApi();
            app.UseSwaggerUi3();
        }
    }
}
