using Microsoft.AspNetCore;

namespace SaasProductImportApi
{
    public class Program
    {
        public static void Main()
        {
            CreateWebHostBuilder().Build().Run(); 
        }

        public static IWebHostBuilder CreateWebHostBuilder()
        {
            return WebHost.CreateDefaultBuilder().UseStartup<ApiStartUp>();
        }
    }
}