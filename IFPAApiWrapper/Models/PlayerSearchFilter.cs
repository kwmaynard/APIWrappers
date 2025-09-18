using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents the filter criteria for searching players.
    /// </summary>
    public class PlayerSearchFilter
    {
        /// <summary>
        /// Gets or sets the name filter.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the country filter.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the state or province filter.
        /// </summary>
        [JsonProperty("stateprov")]
        public string StateProv { get; set; }

        /// <summary>
        /// Gets or sets the tournament filter.
        /// </summary>
        [JsonProperty("tournament")]
        public string Tournament { get; set; }

        /// <summary>
        /// Gets or sets the tournament position filter.
        /// </summary>
        [JsonProperty("tournament_position")]
        public int TournamentPosition { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include unranked players.
        /// </summary>
        [JsonProperty("include_unranked")]
        public string IncludeUnranked { get; set; }
    }
}