using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using RestSharp;

namespace sidosi1 {
    class SidosiClient : ApiClient {

        public SidosiClient() {
            RestClient.BaseUrl = new Uri("https://www.sidosi.org");
        }

        public string Translate(string input) {
            RestRequest req = new RestRequest {
                Resource = "translator",
                Method = Method.POST,
                RequestFormat = DataFormat.Json
            };

            // Set required parameters
            req.AddParameter("lang-to", "to-full-solresol");
            req.AddParameter("text-from", input);
            req.AddParameter("submit", "Send");
            IRestResponse resp = RestClient.Execute(req);

            HtmlNode node = FindDefinition(resp.Content);
            if (node is null) return "Translation not found";

            string output = node.InnerText;

            return SanitizeApiString(output);
        }

        public static string[] FormatAsArray(string input) {
            int k = 0;
            double partSize = 2;
            return input.ToLookup(c => Math.Floor(k++ / partSize))
                .Select(e => new string(e.ToArray())).ToArray();
        }

        private static HtmlNode FindDefinition(string input) {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(input);

            // Use css selector to find the right element, since it doesn't have an id or class
            HtmlNode node = doc.DocumentNode.QuerySelector("#page-body > div:nth-child(6) > p > ol > li:first-child");
            return node;
        }

        static string SanitizeApiString(string inp) {
            int i = inp.IndexOf("[", StringComparison.Ordinal);
            return inp.Substring(0, i);
        }
    }
}