using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Service;

namespace CVService
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
            services.AddScoped<IGetWorkExperience, GetWorkExperience>();
            services.AddScoped<IGetContactDetailsFromDatabase, GeContactDetailsFromDatabase>();
            services.AddScoped<IGetContactDetailsBLL, GetContactDetailsBLL>();
            services.AddScoped<IPostContactDetailsDAL, PostContactDetailsDAL>();
            services.AddScoped<IPostContactDetailsBLL, PostContactDetailsBLL>();
            services.AddScoped<IPostContactDetailsDAL, PostContactDetailsDAL>();
            services.AddScoped<IUpdateContactDetailsDAL, UpdateContactDetailsDAL>();
            services.AddScoped<IUpdateContactDetailsBLL, UpdateContactDetailsBLL>();
            services.AddScoped<IDeleteContactDetailsDAL, DeleteContactDetailsDAL>();
            services.AddScoped<IDeleteContactDetailsBLL, DeleteContactDetailsBLL>();
            services.AddScoped<IGetSkillsDAL, GetSkillsDAL>();
            services.AddScoped<IGetSkillsBLL, GetSkillsBLL>();
            services.AddScoped<IPostSkillDAL, PostSkillDAL>();
            services.AddScoped<IPostSkillBLL, PostSkillBLL>();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger(c =>
            {
                c.SerializeAsV2 = true;
            });

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthorization();

            //Swagger
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
