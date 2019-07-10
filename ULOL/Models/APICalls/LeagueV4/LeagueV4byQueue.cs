namespace ULOL.Models.APICalls.LeagueV4
{

    public class LeagueV4byQueue
    {
        public string queueType { get; set; }
        public string summonerName { get; set; }
        public bool hotStreak { get; set; }
        public int wins { get; set; }
        public bool veteran { get; set; }
        public int losses { get; set; }
        public string rank { get; set; }
        public string tier { get; set; }
        public bool inactive { get; set; }
        public bool freshBlood { get; set; }
        public string leagueId { get; set; }
        public string summonerId { get; set; }
        public int leaguePoints { get; set; }
        public Miniseries miniSeries { get; set; }
    }

    public class Miniseries
    {
        public int wins { get; set; }
        public int losses { get; set; }
        public int target { get; set; }
        public string progress { get; set; }
    }

}