using RestSharp;
using HtmlAgilityPack;

namespace sidosi
{
    class SidosiClient
    {
        public string Translate(string input) {
            RestClient clinet = new RestClient("https://www.sidosi.org/");
            RestRequest req = new RestRequest("translator")
            {
                Method = Method.POST,
                RequestFormat = DataFormat.Json
            };
            /*
               lang-to: to-full-solresol
               text-from: test
               submit: Send
             */
            req.AddParameter("lang-to", "to-full-solresol");
            req.AddParameter("text-from", input);
            req.AddParameter("submit","Send");
            IRestResponse resp =  clinet.Execute(req);
            var doc = new HtmlDocument();
            doc.LoadHtml(resp.Content);
            // /html/body/div[3]/div[3]/div[3]/ol/li[1]
            HtmlNode node = doc.DocumentNode;

            return node.InnerHtml;
        }
    }
}
