using Microsoft.Extensions.Configuration;

namespace tinyBlazorAdmin.Data
{
    public class UrlShortenerService
    {
        public IConfiguration Config { get; set; }

        public UrlShortenerService(IConfiguration config)
        {
            Config = config;
        }
    }
}