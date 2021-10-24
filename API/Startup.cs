using API.Controllers;
using Domain.Departments;
using Domain.Employees;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository;

namespace API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMemoryCache();

            services.AddControllers(options => options.EnableEndpointRouting = false);
            
            services.AddHttpContextAccessor();

            var connectionString = @"Server=localhost\SQLEXPRESS01;Database=testCase;Trusted_Connection=True;";
            services.AddDbContext<EfContext>(options =>
                options.UseSqlServer(connectionString, builder => builder.EnableRetryOnFailure()));

            services.AddSwaggerGen();

            services.AddScoped<IEfContext, EfContext>();
            services.AddScoped<IDepartmentsRepository, DepartmentsRepository>();
            services.AddScoped<IEmployeesRepository, EmployeesRepository>();
            
            
            services.AddScoped<DepartmentsController, DepartmentsController>();
            services.AddScoped<EmployeesController, EmployeesController>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            
            app.UseRouting();

            
            
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
            
            app.UseSwagger();
            app.UseSwaggerUI();
        }
    }
}