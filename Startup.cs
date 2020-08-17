using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Pizzaria.API.Domain.Repositories;
using Pizzaria.API.Domain.Services;
using Pizzaria.API.Persistence.Contexts;
using Pizzaria.API.Persistence.Repositories;
using Pizzaria.API.Services;
using Microsoft.EntityFrameworkCore;

namespace Pizzaria.API
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
            services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("Context")));

            services.AddControllers();

            services.AddScoped<IClientesRepository, ClientesRepository>();
            services.AddScoped<IClientesService, ClientesService>();

            services.AddScoped<IEnderecosClientesRepository, EnderecosClientesRepository>();
            services.AddScoped<IEnderecosClientesService, EnderecosClientesService>();

            services.AddScoped<IPedidosRepository, PedidosRepository>();
            services.AddScoped<IPedidosService, PedidosService>();

            services.AddScoped<ISaboresPizzaRepository, SaboresPizzaRepository>();
            services.AddScoped<ISaboresPizzaService, SaboresPizzaService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
