using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a player's statistics for different systems.
    /// </summary>
    public class PlayerStatsSystem
    {
        /// <summary>
        /// Gets or sets the player's main statistics.
        /// </summary>
        [JsonProperty("MAIN")]
        public PlayerStatsDetail Main { get; set; }

        /// <summary>
        /// Gets or sets the player's women's statistics.
        /// </summary>
        [JsonProperty("WOMEN")]
        public PlayerStatsDetail Women { get; set; }
    }
}