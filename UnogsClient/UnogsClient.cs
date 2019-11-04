﻿
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using RestSharp;

namespace UnogsClient
{
    public class UnogsClient {
        private const string BaseUrl = "https://streamzui-streamzui-v1.p.rapidapi.com/";
        private RestClient client;
        private readonly string apiKey; 

        public UnogsClient() {
            client = new RestClient(BaseUrl);
            apiKey = File.ReadAllText(Directory.GetCurrentDirectory() + "\\apikey.txt").Trim();
        }

        public ApiItem GetTitleByName(string name) {
            RestClient client = new RestClient($"https://unogs-unogs-v1.p.rapidapi.com/aaapi.cgi?q=get%3A{name}-!1900%2C2019-!0%2C5-!0%2C10-!0-!Any-!Any-!Any-!gt100-!%7Bdownloadable%7D&t=ns&cl=all&st=adv&ob=Relevance&p=1&sa=and");
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "unogs-unogs-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", apiKey);
            IRestResponse response = client.Execute(request);

            ApiResponse resp = JsonConvert.DeserializeObject<ApiResponse>(response.Content);
            return resp.Items[0];
        }
    }
}
