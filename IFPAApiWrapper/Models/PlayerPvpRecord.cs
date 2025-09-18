using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a player-vs-player record for a player.
    /// </summary>
    public class PlayerPvpRecord
    {
        /// <summary>
        /// Gets or sets the player's ID.
        /// </summary>
        [JsonProperty("player_id")]
        public int PlayerId { get; set; }

        /// <summary>
        /// Gets or sets the player's first name.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the player's last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the number of wins.
        /// </summary>
        [JsonProperty("win_count")]
        public int WinCount { get; set; }

        /// <summary>
        /// Gets or sets the number of losses.
        /// </summary>
        [JsonProperty("loss_count")]
        public int LossCount { get; set; }

        /// <summary>
        /// Gets or sets the number of ties.
        /// </summary>
        [JsonProperty("tie_count")]
        public int TieCount { get; set; }

        /// <summary>
        /// Gets or sets the current rank of the player.
        /// </summary>
        [JsonProperty("current_rank")]
        public int CurrentRank { get; set; }
    }
}