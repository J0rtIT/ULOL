namespace ULOL.Models.APICalls.SpectatorV4
{

    public class Featured
    {
        public int clientRefreshInterval { get; set; }
        public Gamelist[] gameList { get; set; }
    }

    public class Gamelist
    {
        public long gameId { get; set; }
        public long gameStartTime { get; set; }
        public string platformId { get; set; }
        public string gameMode { get; set; }
        public int mapId { get; set; }
        public string gameType { get; set; }
        public int gameQueueConfigId { get; set; }
        public Observers observers { get; set; }
        public Participant[] participants { get; set; }
        public int gameLength { get; set; }
        public Bannedchampion[] bannedChampions { get; set; }
    }

    public class Observers
    {
        public string encryptionKey { get; set; }
    }

    public class Participant
    {
        public int profileIconId { get; set; }
        public int championId { get; set; }
        public string summonerName { get; set; }
        public bool bot { get; set; }
        public int spell2Id { get; set; }
        public int teamId { get; set; }
        public int spell1Id { get; set; }
    }

    public class Bannedchampion
    {
        public int teamId { get; set; }
        public int championId { get; set; }
        public int pickTurn { get; set; }
    }

}