using Microsoft.Extensions.Configuration;
using SauceDemoAdapterPattern.Models;

namespace SauceDemoAdapterPattern.Config
{
    public static class TestConfig
    {
        private static IConfigurationRoot _configuration;

        static TestConfig()
        {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        }

        public static Credentials GetCredentials()
        {
            return _configuration
                .GetSection("Credentials")
                .Get<Credentials>();
        }
    }
}
