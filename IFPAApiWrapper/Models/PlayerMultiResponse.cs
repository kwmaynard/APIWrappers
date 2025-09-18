using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a response containing multiple players.
    /// </summary>
    public class PlayerMultiResponse
    {
        /// <summary>
        /// Gets or sets the list of players in the response.
        /// </summary>
        [JsonProperty("player")]
        public List<Player> Players { get; set; }
    }
}