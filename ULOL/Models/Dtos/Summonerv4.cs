using Newtonsoft.Json;
using System.Net;

namespace ULOL.Models.Dtos
{
    public class Summonerv4
    {
        public string APIkey { get; set; } = "RGAPI-8bd4fe47-fc05-4f15-8a78-68365e282b99";

        public int profileIconId { get; set; }
        public string name { get; set; }
        public string puuid { get; set; }
        public int summonerLevel { get; set; }
        public string accountId { get; set; }
        public string id { get; set; }
        public long revisionDate { get; set; }

        public Summonerv4()
        {
        }

        public Summonerv4(string summonerName)
        {
            WebClient wc = new WebClient();
            wc.Headers.Add("X-Riot-Token", APIkey);
            wc.Headers.Add("Content-Type", "application/json;charset=utf-8");

            string respose = wc.DownloadString($"https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/{summonerName}");
            //json into object

            Summonerv4 result = JsonConvert.DeserializeObject<Summonerv4>(respose);

            accountId = result.accountId;
            id = result.id;
            name = result.name;
            profileIconId = result.profileIconId;
            puuid = result.puuid;
            revisionDate = result.revisionDate;
            summonerLevel = result.summonerLevel;
        }

        public Summonerv4(Summonerv4 s4)
        {
            accountId = s4.accountId;
            id = s4.id;
            name = s4.name;
            profileIconId = s4.profileIconId;
            puuid = s4.puuid;
            revisionDate = s4.revisionDate;
            summonerLevel = s4.summonerLevel;
        }

        public class PropertyCopier<TParent, TChild> where TParent : class
            where TChild : class
        {
            public static void Copy(TParent parent, TChild child)
            {
                var parentProperties = parent.GetType().GetProperties();
                var childProperties = child.GetType().GetProperties();

                foreach (var parentProperty in parentProperties)
                {
                    foreach (var childProperty in childProperties)
                    {
                        if (parentProperty.Name == childProperty.Name && parentProperty.PropertyType == childProperty.PropertyType)
                        {
                            childProperty.SetValue(child, parentProperty.GetValue(parent));
                            break;
                        }
                    }
                }
            }
        }
    }



}