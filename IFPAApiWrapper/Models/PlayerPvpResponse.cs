using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a player-vs-player response for a player.
    /// </summary>
    public class PlayerPvpResponse
    {
        /// <summary>
        /// Gets or sets the player's ID.
        /// </summary>
        [JsonProperty("player_id")]
        public int PlayerId { get; set; }

        /// <summary>
        /// Gets or sets the total number of competitors.
        /// </summary>
        [JsonProperty("total_competitors")]
        public int TotalCompetitors { get; set; }

        /// <summary>
        /// Gets or sets the ranking system used.
        /// </summary>
        [JsonProperty("system")]
        public string System { get; set; }

        /// <summary>
        /// Gets or sets the list of player-vs-player records.
        /// </summary>
        [JsonProperty("pvp")]
        public List<PlayerPvpRecord> Pvp { get; set; }
    }
}