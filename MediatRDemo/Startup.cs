using MediatRDemo.Application.Cliente;
using FluentValidation;
using MediatR;
using MediatRDemo.Application.Common.Behavior;
using MediatRDemo.Cliente;
using MediatRDemo.Core.Behavior;
using MediatRDemo.Core.Interfaces;
using MediatRDemo.DAL;
using MediatRDemo.Proposta;
using MediatRDemo.Web.Filters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FluentValidation.AspNetCore;
using System.Reflection;
using System.IO;
using System;
using Microsoft.OpenApi.Models;

namespace MediatRDemo
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
            services.AddControllersWithViews();
            services.AddMvc(config =>
                config.Filters.Add(typeof(ExceptionFilter)))
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<ClienteValidator>()); ;

            services.AddMediatR(typeof(LogBehavior<,>).Assembly);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LogBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(FailFastBehavior<,>));

            services.AddTransient(typeof(IBoProposta), typeof(BoProposta));
            services.AddTransient(typeof(IBoCliente), typeof(BoCliente));
            services.AddTransient(typeof(IDispatcherCliente), typeof(DispatcherCliente));
            services.AddTransient(typeof(IDispatcherProposta), typeof(DispatcherProposta));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo() { Title = "Web App", Version = "v1" });
                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
