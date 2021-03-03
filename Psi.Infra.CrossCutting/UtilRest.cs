using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Infra.CrossCutting
{
    public static class UtilRest
    {
        public static IRestResponse RequestClient(Method method, string URL, object obj = null, string contentType = "application/json", ParameterType parameterType = ParameterType.RequestBody)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(method);
            request.AddHeader("Content-Type", contentType);
            request.AddParameter(contentType, obj, parameterType);
            IRestResponse response = client.Execute(request);

            return response;
        }

        public static string CreateFormBody(Dictionary<string, string> body)
        {
            var result = body.Select(x => $"{x.Key}={x.Value}").Aggregate((i, j) => i + "&" + j);

            return result;
        }
    }
}
