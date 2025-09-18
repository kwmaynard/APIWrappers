using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents the finish positions of players in an event or match.
    /// </summary>
    public class FinishPosition
    {
        /// <summary>
        /// Gets or sets the ID of the first player.
        /// </summary>
        [JsonProperty("player_1")]
        public int Player1 { get; set; }

        /// <summary>
        /// Gets or sets the ID of the second player.
        /// </summary>
        [JsonProperty("player_2")]
        public int Player2 { get; set; }
    }
}