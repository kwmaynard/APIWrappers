using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a filter for searching tournaments.
    /// </summary>
    public class TournamentSearchFilter
    {
        /// <summary>
        /// Gets or sets the name of the tournament.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the country where the tournament is held.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the state or province where the tournament is held.
        /// </summary>
        [JsonProperty("stateprov")]
        public string StateProv { get; set; }

        /// <summary>
        /// Gets or sets the city where the tournament is held.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the director's ID for the tournament.
        /// </summary>
        [JsonProperty("director_id")]
        public int? DirectorId { get; set; }

        /// <summary>
        /// Gets or sets the year of the tournament.
        /// </summary>
        [JsonProperty("year")]
        public int? Year { get; set; }
    }
}