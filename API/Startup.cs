using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bussines;
using Bussines.Area;
using Data_Access;
using Data_Access.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace API
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

            services.AddMvc();
            services.AddDbContext<NBAContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddSwaggerGen(config =>
            {
                config.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
                {
                    Title = "Prueba-Api"
                });
            });
            services.AddTransient<IPatientService, PatientService>();
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddTransient<IDoctorService, DoctorService>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddTransient<IDetailPatientDoctorService, DetailPatientDoctorService>();
            services.AddScoped<IDetailPatientDoctorRepository, DetailPatientDoctorRepository>();
            services.AddScoped<INBAContext, NBAContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
           
            app.UseSwagger();
            app.UseSwaggerUI(config =>
            {
                config.SwaggerEndpoint("/swagger/v1/swagger.json", "Api");
            });
            
            app.UseMvc();
        }
    }
}
