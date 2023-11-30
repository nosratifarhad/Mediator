using Microsoft.OpenApi.Models;
using WebApplicationMediator.Domain;
using WebApplicationMediator.Repository;

namespace WebApplicationMediator;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IProductRepository, ProductRepository>();

        #region [ Mediator ]

        ///First Install nuget packages
        ///
        ///NuGet\Install-Package Mediator.SourceGenerator -Version 2.1.1
        ///dotnet add package Mediator.SourceGenerator --version 2.1.1
        ///
        ///AND
        ///
        ///NuGet\Install-Package Mediator.Abstractions -Version 2.1.1
        ///dotnet add package Mediator.Abstractions --version 2.1.1

        services.AddMediator(options =>
        {
            options.Namespace = "WebApplicationMediator";
            options.ServiceLifetime = ServiceLifetime.Transient;
        });

        #endregion [ Mediator ]

        services.AddControllers();

        #region [ Swagger ]
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApplicationMediator", Version = "v1" });
        });
        #endregion [ Swagger ]
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApplicationMediator v1"));
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}