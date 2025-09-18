using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a player's statistics.
    /// </summary>
    public class PlayerStats
    {
        /// <summary>
        /// Gets or sets the player's statistics system.
        /// </summary>
        [JsonProperty("system")]
        public PlayerStatsSystem System { get; set; }
    }
}