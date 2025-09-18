using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a response containing a player's results.
    /// </summary>
    public class PlayerResultsResponse
    {
        /// <summary>
        /// Gets or sets the player's ID.
        /// </summary>
        [JsonProperty("player_id")]
        public int PlayerId { get; set; }

        /// <summary>
        /// Gets or sets the type of results.
        /// </summary>
        [JsonProperty("results_type")]
        public string ResultsType { get; set; }

        /// <summary>
        /// Gets or sets the count of results.
        /// </summary>
        [JsonProperty("results_count")]
        public int ResultsCount { get; set; }

        /// <summary>
        /// Gets or sets the ranking system used.
        /// </summary>
        [JsonProperty("system")]
        public string System { get; set; }

        /// <summary>
        /// Gets or sets the list of player results.
        /// </summary>
        [JsonProperty("results")]
        public List<PlayerResult> Results { get; set; }
    }
}