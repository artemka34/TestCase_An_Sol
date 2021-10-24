using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace WebConfigurationApplication.Utils
{
    public class HttpRequestMessageBuilder
    {
        public StringContent CreateMessageContent(object @object, bool ignoreNulls = true)
        {
            var json = JsonConvert.SerializeObject(@object, Formatting.None,
                new JsonSerializerSettings
                {
                    NullValueHandling = ignoreNulls ? NullValueHandling.Ignore : NullValueHandling.Include,
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                });

            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}