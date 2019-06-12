namespace ULOL.Models.EndPoints
{
    public static class Apiendpoints
    {
        public static string GetSummonerv4ByName(string name)
        {
            return $"/lol/summoner/v4/summoners/by-name/{name}";
        }

        public static string SpectatorFeatured()
        {
            return $"/lol/spectator/v4/featured-games";
        }

        public static string SpectatorSummonerId(string encryptedSummonerId)
        {
            return $"/lol/spectator/v4/active-games/by-summoner/{encryptedSummonerId}";
        }

    }
}