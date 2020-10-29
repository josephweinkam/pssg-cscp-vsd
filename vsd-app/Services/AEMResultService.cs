using Gov.Cscp.VictimServices.Public.Models;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System;

namespace Gov.Cscp.VictimServices.Public.Services
{
    public interface IAEMResultService
    {
        Task<AEMResult> Post(string requestJson);
    }

    public class AEMResultService : IAEMResultService
    {
        private HttpClient _client;
        private IConfiguration _configuration;

        public AEMResultService(IConfiguration configuration, HttpClient httpClient)
        {
            _client = httpClient;
            _configuration = configuration;
        }


        public async Task<AEMResult> Post(string modelJson)
        {
            AEMResult blob = await AEMResultAsync(modelJson);
            return blob;
        }

        private async Task<AEMResult> AEMResultAsync(string requestJson)
        {
            string endpointUrl = _configuration["AEM_INTERFACE_URI"];
            requestJson = requestJson.Replace("fortunecookie", "@odata.");

            Console.WriteLine(endpointUrl);
            Console.WriteLine(requestJson);

            HttpRequestMessage _httpRequest = new HttpRequestMessage(HttpMethod.Post, endpointUrl);
            _httpRequest.Content = new StringContent(requestJson, System.Text.Encoding.UTF8, "application/json");

            var _httpResponse = await _client.SendAsync(_httpRequest);
            HttpStatusCode _statusCode = _httpResponse.StatusCode;

            var _responseContent = await _httpResponse.Content.ReadAsStringAsync();

            var result = new AEMResult();
            result.responseCode = _statusCode;
            result.responseMessage = _responseContent;

            Console.WriteLine(result);

            return result;
        }
    }
}