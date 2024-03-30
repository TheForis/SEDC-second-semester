namespace Demo2.Models
{
    public static class PlayerHelper
    {
        public static string GetStats(FootballPlayer player)
        {
            return $"For the footballer {player.GetData()} \n Mark: 9.3";
        }
        public static string GetStats(BasketballPlayer player)
        {
            return $"For this basketballer: {player.GetData()} \n Mark: 8.3";
        }
        public static string GetStats(User player,decimal mark)
        {
            return $"For this player: {player.GetData()} \n Mark: {mark}";
        }
    }
}
