using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using ULOL.Models.APICalls.SummonerByNameV4;
using ULOL.Models.EndPoints;

namespace ULOL.Models.APICalls
{
    public class WebApiCall
    {
        static HttpClient client = new HttpClient();
        private static HttpWebRequest Request { get; set; }



        public async Task<string> CallSummonerV4ByNameAsync(string str)
        {
            string calling = $"https://{RegionalEndpoints.GetEndPoint("NA")}{Apiendpoints.GetSummonerv4ByName(str)}";
            //client.BaseAddress = new Uri(calling);
            client.DefaultRequestHeaders.Add("X-Riot-Token", ApiKey.Apikey);
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
            Request.Headers.Add("X-Riot-Token", ApiKey.Apikey);

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
            Request.Headers.Add("X-Riot-Token", ApiKey.Apikey);

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
            client.DefaultRequestHeaders.Add("X-Riot-Token", ApiKey.Apikey);
            client.DefaultRequestHeaders.Add("ContentType", "application/json");
            return await client.GetStringAsync(calling);
        }

        public string CallSpectatorFeatured()
        {
            string calling = $"https://{RegionalEndpoints.GetEndPoint("NA")}{Apiendpoints.SpectatorFeatured()}";

            Request = (HttpWebRequest)WebRequest.Create(calling);
            Request.Method = "GET";
            Request.ContentType = "application/json";
            Request.Headers.Add("X-Riot-Token", ApiKey.Apikey);

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


        public async Task<string> CallStatusV3()
        {
            string calling = $"https://{RegionalEndpoints.GetEndPoint("NA")}{Apiendpoints.StatusV3()}";
            //client.BaseAddress = new Uri(calling);
            client.DefaultRequestHeaders.Add("X-Riot-Token", ApiKey.Apikey);
            client.DefaultRequestHeaders.Add("ContentType", "application/json");
            return await client.GetStringAsync(calling);
        }

        
        public async Task<string> CallLeagueByQueue()
        {
            string calling = $"https://{RegionalEndpoints.GetEndPoint("NA")}{Apiendpoints.LeagueByQueueV4(RankedQueue.GetEndPoint("RANKED_SOLO_5x5"), Tier.GetTier("DIAMOND"), Division.GetDivision("I"))}";
            //client.BaseAddress = new Uri(calling);
            client.DefaultRequestHeaders.Add("X-Riot-Token", ApiKey.Apikey);
            client.DefaultRequestHeaders.Add("ContentType", "application/json");
            return await client.GetStringAsync(calling);
        }
        /*to be implemented*/

        //champion masteries 
        public async Task<string> CallRankedStatsV3()
        {
            string calling = $"https://{RegionalEndpoints.GetEndPoint("NA")}{Apiendpoints.StatusV3()}";
            //client.BaseAddress = new Uri(calling);
            client.DefaultRequestHeaders.Add("X-Riot-Token", ApiKey.Apikey);
            client.DefaultRequestHeaders.Add("ContentType", "application/json");
            return await client.GetStringAsync(calling);
        }





    }
}