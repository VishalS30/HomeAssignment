using SaasProductImportApi.DI;

namespace SaasProductImportApi
{
    public class ApiStartUp
    {
        public IConfiguration configuration { get; set; }

        public ApiStartUp(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSwaggerGen();
            return DiProvider.LoadDepedencies(services, configuration);
        }

        public void Configure(IApplicationBuilder applicationBuilder, IWebHostEnvironment hostEnvironment)
        {
            if (hostEnvironment.IsDevelopment())
            {
                applicationBuilder.UseDeveloperExceptionPage();
            }
            applicationBuilder.UseRouting();

            applicationBuilder.UseEndpoints(endpoints => { endpoints.MapControllers(); });

            applicationBuilder.UseSwagger();

            applicationBuilder.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Saas Products Import Api");
            });
        }
    }
}
