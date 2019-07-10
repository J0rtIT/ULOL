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

        public static string StatusV3()
        {
            return $"/lol/status/v3/shard-data";
        }

        public static string LeagueByQueueV4(string queue, string tier, string division, int page = 1)
        {
            return $"lol/league/v4/entries/{queue}/{tier}/{division}?page={page}";
        }



    }
}

/*
 * var FolderPath = HttpContext.Current.Server.MapPath("~/SummonersData/EncryptedData");
            using (StreamWriter writer = new StreamWriter($"{FolderPath}\\{encryptedSummonerId}.txt", true)
            {
                    writer.WriteLine(encryptedSummonerId);
            }

    */
