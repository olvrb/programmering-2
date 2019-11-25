using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace sidosi1
{
    class ApiClient {
        public string BaseUrl => RestClient.BaseUrl.ToString();
        public RestClient RestClient { get; protected set; }

        public ApiClient() {
            RestClient = new RestClient();
        }
    }
}
