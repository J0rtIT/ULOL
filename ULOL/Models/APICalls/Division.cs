using System.Collections.Generic;

namespace ULOL.Models.APICalls
{
    public static class Division
    {

        public static Dictionary<string, string> division { get; set; } =
            new Dictionary<string, string>
            {
                {"I","I"},
                {"II","II"},
                {"III","III"},
                {"IV","IV"},
            };

        public static string GetDivision(string key)
        {
            return division[key];
        }
    }
}