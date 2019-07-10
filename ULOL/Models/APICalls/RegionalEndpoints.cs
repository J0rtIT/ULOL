using System.Collections.Generic;

namespace ULOL.Models.APICalls
{
    public static class RegionalEndpoints
    {
        public static Dictionary<string, string> Endpoint { get; set; } =
        new Dictionary<string, string>
        {
            {"BR","br1.api.riotgames.com"},
            {"EUNE","eun1.api.riotgames.com"},
            {"EUW","euw1.api.riotgames.com"},
            {"JP","jp1.api.riotgames.com"},
            {"KR","kr.api.riotgames.com"},
            {"LAN","la1.api.riotgames.com"},
            {"LAS","la2.api.riotgames.com"},
            {"NA","na1.api.riotgames.com"},
            {"OCE","oc1.api.riotgames.com"},
            {"TR","tr1.api.riotgames.com"},
            {"RU","ru.api.riotgames.com"},
            {"PBE","pbe1.api.riotgames.com"}
        };

        public static string GetEndPoint(string region)
        {
            return Endpoint[region];
        }

    }
}
