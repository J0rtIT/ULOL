using System.Collections.Generic;

namespace ULOL.Models.APICalls
{
    public static class RankedQueue
    {
        public static Dictionary<string, string> queue { get; set; } =
            new Dictionary<string, string>
            {
            {"RANKED_SOLO_5x5","RANKED_SOLO_5x5"},
            {"RANKED_FLEX_SR","RANKED_FLEX_SR"},
            {"RANKED_FLEX_TT","RANKED_FLEX_TT"}
            };

        public static string GetEndPoint(string key)
        {
            return queue[key];
        }

    }
}