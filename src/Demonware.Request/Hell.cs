using RestSharp;
using RestSharp.Serializers;

namespace Demonware.Request
{
    public static class Hell
    {
        public static IRestResponse<T> HailSatan<T>(string endpoint, Method method, params RequestParameter[] parameters) where T : new()
        {
            var client = new RestClient("https://dev01-ecom2-1800contacts.demandware.net/s/1800contacts");
            var request = new RestRequest(endpoint, method);

            foreach (var parameter in parameters)
            {
                request.AddParameter(parameter.Name, parameter.Value);
            }

            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer = new JsonSerializer();
            var result = client.Execute<T>(request);

            return result;
        }
    }
}
