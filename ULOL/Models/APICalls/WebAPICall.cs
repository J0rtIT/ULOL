using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using ULOL.Models.ApiCalls.SummonerByNameV4;
using ULOL.Models.EndPoints;

namespace ULOL.Models.ApiCalls
{
    public class WebApiCall
    {
        static HttpClient client = new HttpClient();
        private static HttpWebRequest Request { get; set; }



        public async Task<string> CallSummonerV4ByNameAsync(string str)
        {
            string calling = $"https://{RegionalEndpoints.GetEndPoint("NA")}{Apiendpoints.GetSummonerv4ByName(str)}";
            //client.BaseAddress = new Uri(calling);
            client.DefaultRequestHeaders.Add("X-Riot-Token", Apikey.apikey);
            client.DefaultRequestHeaders.Add("ContentType", "application/json");

            var res = await client.GetAsync(calling);
            return res.ToString();

        }

        public string CallSummonerV4ByName(string str)
        {
            string calling = $"https://{RegionalEndpoints.GetEndPoint("NA")}{Apiendpoints.GetSummonerv4ByName(str)}";

            Request = (HttpWebRequest)WebRequest.Create(calling);
            Request.Method = "GET";
            Request.ContentType = "application/json";
            Request.Headers.Add("X-Riot-Token", Apikey.apikey);

            try
            {
                WebResponse webResponse = Request.GetResponse();
                using (Stream webStream = webResponse.GetResponseStream() ?? Stream.Null)
                using (StreamReader responseReader = new StreamReader(webStream))
                {
                    return responseReader.ReadToEnd();
                }
            }
            catch (Exception)
            {
                //todo add message here
            }
            return string.Empty;
        }

        public SummonerByNameV4Model CallSummonerV4ByNameModel(string str)
        {
            string calling = $"https://{RegionalEndpoints.GetEndPoint("NA")}{Apiendpoints.GetSummonerv4ByName(str)}";

            Request = (HttpWebRequest)WebRequest.Create(calling);
            Request.Method = "GET";
            Request.ContentType = "application/json";
            Request.Headers.Add("X-Riot-Token", Apikey.apikey);

            try
            {
                WebResponse webResponse = Request.GetResponse();
                using (Stream webStream = webResponse.GetResponseStream() ?? Stream.Null)
                using (StreamReader responseReader = new StreamReader(webStream))
                {
                    return JsonConvert.DeserializeObject<SummonerByNameV4Model>(responseReader.ReadToEnd());
                }

            }
            catch (Exception)
            {
                //TODO: ADD EXCEPTION MESSAGE HERE
            }
            return new SummonerByNameV4Model();
        }


        public async Task<string> CallSpectatorFeaturedAsync(string str)
        {
            /*
            string summonersDataFolder = HttpContext.Current.Server.MapPath("/SummonersData/");
            var AllFiles = Directory.GetFiles(summonersDataFolder);
            foreach (File f in AllFiles)
            {
                if(f)
            }
            */

            string calling = $"https://{RegionalEndpoints.GetEndPoint("NA")}{Apiendpoints.SpectatorFeatured()}";
            client.DefaultRequestHeaders.Add("X-Riot-Token", Apikey.apikey);
            client.DefaultRequestHeaders.Add("ContentType", "application/json");

            //SummonerByNameV4 s4 = new SummonerByNameV4();

            var res = await client.GetAsync(calling);


            return res.ToString();

        }

        public string CallSpectatorFeatured()
        {
            string calling = $"https://{RegionalEndpoints.GetEndPoint("NA")}{Apiendpoints.SpectatorFeatured()}";

            Request = (HttpWebRequest)WebRequest.Create(calling);
            Request.Method = "GET";
            Request.ContentType = "application/json";
            Request.Headers.Add("X-Riot-Token", Apikey.apikey);

            try
            {
                WebResponse webResponse = Request.GetResponse();
                using (Stream webStream = webResponse.GetResponseStream() ?? Stream.Null)
                using (StreamReader responseReader = new StreamReader(webStream))
                {
                    return responseReader.ReadToEnd();
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}