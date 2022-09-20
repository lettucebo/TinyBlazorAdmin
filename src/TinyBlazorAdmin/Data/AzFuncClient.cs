using System.Threading.Tasks;

namespace TinyBlazorAdmin.Data
{
    /// <summary>
    /// Service to access the Cosmos DB blog posts.
    /// </summary>
    public class AzFuncClient
    {
        /// <summary>
        /// The <see cref="UrlShortenerSecuredService"/> to retrieve credentials.
        /// </summary>
        private readonly UrlShortenerSecuredService _urlSecuredService;

        /// <summary>
        /// Creates a new instance of the <see cref="AzFuncClient"/> class.
        /// </summary>
        /// <param name="urlSecuredService">The <see cref="UrlShortenerSecuredService"/> to request the token.</param>
        public AzFuncClient(UrlShortenerSecuredService urlSecuredService)
        {
            _urlSecuredService = urlSecuredService;
        }

        public async Task<ShortUrlList> GetUrlList()
        {
            var result = await _urlSecuredService.GetUrlList().ConfigureAwait(false);
            return result;
        }

        public async Task<ShortUrlList> CreateShortUrl(ShortUrlRequest shortUrlRequest)
        {
            var result = await _urlSecuredService.CreateShortUrl(shortUrlRequest).ConfigureAwait(false);
            return result;
        }

        public async Task<ShortUrlEntity> UpdateShortUrl(ShortUrlEntity editedUrl)
        {
            var result = await _urlSecuredService.UpdateShortUrl(editedUrl).ConfigureAwait(false);
            return result;
        }

        public async Task<ShortUrlEntity> ArchiveShortUrl(ShortUrlEntity archivedUrl)
        {
            var result = await _urlSecuredService.ArchiveShortUrl(archivedUrl).ConfigureAwait(false);
            return result;
        }

        public async Task<ClickDateList> GetClickStats(string vanity)
        {
            var result = await _urlSecuredService.GetClickStats(vanity).ConfigureAwait(false);
            return result;
        }

    }
}