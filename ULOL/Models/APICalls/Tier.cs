using System.Collections.Generic;

namespace ULOL.Models.APICalls
{
    public static class Tier
    {

        public static Dictionary<string, string> tier { get; set; } =
            new Dictionary<string, string>
            {
                {"DIAMOND","DIAMOND"},
                {"PLATINUM","PLATINUM"},
                {"GOLD","GOLD"},
                {"SILVER","SILVER"},
                {"BRONZE","BRONZE"},
                {"IRON","IRON"}
            };

        public static string GetTier(string key)
        {
            return tier[key];
        }
    }
}