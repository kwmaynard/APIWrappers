using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a player's rank history entry.
    /// </summary>
    public class PlayerRankHistory
    {
        /// <summary>
        /// Gets or sets the date of the rank entry.
        /// </summary>
        [JsonProperty("rank_date")]
        public string RankDate { get; set; }

        /// <summary>
        /// Gets or sets the rank position.
        /// </summary>
        [JsonProperty("rank_postiion")]
        public int RankPosition { get; set; }

        /// <summary>
        /// Gets or sets the WPPR points for the rank entry.
        /// </summary>
        [JsonProperty("wppr_points")]
        public double WpprPoints { get; set; }

        /// <summary>
        /// Gets or sets the number of tournaments played at this rank entry.
        /// </summary>
        [JsonProperty("tournaments_played_count")]
        public int TournamentsPlayedCount { get; set; }
    }
}