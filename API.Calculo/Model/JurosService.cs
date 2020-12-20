using Newtonsoft.Json;
using RestSharp;

namespace API.Calculo.Model
{
    public sealed class JurosService
    {
        public static JurosEntity GetJurosAtual()
        {
            RestClient restClient = new RestClient("https://localhost:5001");
            RestRequest request = new RestRequest("/taxaJuros", Method.GET);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };

            string jsonResponse = restClient.Execute(request).Content;

            return JsonConvert.DeserializeObject<JurosEntity>(jsonResponse);
        }
    }
}
