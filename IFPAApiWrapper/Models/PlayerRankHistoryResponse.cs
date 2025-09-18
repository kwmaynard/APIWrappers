using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a response containing a player's rank history.
    /// </summary>
    public class PlayerRankHistoryResponse
    {
        /// <summary>
        /// Gets or sets the player's ID.
        /// </summary>
        [JsonProperty("player_id")]
        public int PlayerId { get; set; }

        /// <summary>
        /// Gets or sets the ranking system used.
        /// </summary>
        [JsonProperty("system")]
        public string System { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the player is active.
        /// </summary>
        [JsonProperty("active_flag")]
        public bool ActiveFlag { get; set; }

        /// <summary>
        /// Gets or sets the list of rank history entries for the player.
        /// </summary>
        [JsonProperty("rank_history")]
        public List<PlayerRankHistory> RankHistory { get; set; }

        /// <summary>
        /// Gets or sets the list of rating history entries for the player.
        /// </summary>
        [JsonProperty("rating_history")]
        public List<PlayerRatingHistory> RatingHistory { get; set; }
    }
}