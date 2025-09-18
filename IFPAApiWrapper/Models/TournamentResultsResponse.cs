using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a response containing tournament results.
    /// </summary>
    public class TournamentResultsResponse
    {
        /// <summary>
        /// Gets or sets the tournament ID.
        /// </summary>
        [JsonProperty("tournament_id")]
        public int TournamentId { get; set; }

        /// <summary>
        /// Gets or sets the list of tournament results.
        /// </summary>
        [JsonProperty("results")]
        public List<TournamentResult> Results { get; set; }
    }
}