using System.Threading.Tasks;
using RestSharp;

namespace Jeopicodus.Models
{
    // class ApiHelper
    // {
    //     public static async Task<string> ApiCall(string apiKey)
    //     {
    //         RestClient client = new RestClient("");
    //         RestRequest request = new RestRequest($"home.json?api-key={apiKey}", Method.GET);
    //         var response = await client.ExecuteTaskAsync(request);
    //         return response.Content;
    //     }
    // }

    class ApiHelper
    {
        public static async Task<string> ApiCall(string questionType)
        {
            RestClient client = new RestClient($"http://jeopicodusapi.azurewebsites.net/api/{questionType}");
            // RestClient client = new RestClient($"http://localhost:5000/api/{questionType}");
            RestRequest request = new RestRequest("/", Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }
    }
}