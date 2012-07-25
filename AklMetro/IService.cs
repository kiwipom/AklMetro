using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace AklMetro
{
    public interface IService
    {
        Task<string> GetQuestionsAsync();
    }

    class RealService : IService
    {
        private readonly HttpClient _client;

        public RealService()
        {
            var handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip
            };
            _client = new HttpClient(handler);
        }


        public async Task<string> GetQuestionsAsync()
        {
            const string url = @"https://api.stackexchange.com/2.0/questions?order=desc&sort=activity&site=stackoverflow";
            return await _client.GetStringAsync(url);
        }
    }
}