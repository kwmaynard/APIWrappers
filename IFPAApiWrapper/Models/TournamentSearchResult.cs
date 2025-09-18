using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a tournament search result.
    /// </summary>
    public class TournamentSearchResult
    {
        /// <summary>
        /// Gets or sets the tournament ID.
        /// </summary>
        [JsonProperty("tournament_id")]
        public int TournamentId { get; set; }

        /// <summary>
        /// Gets or sets the tournament name.
        /// </summary>
        [JsonProperty("tournament_name")]
        public string TournamentName { get; set; }

        /// <summary>
        /// Gets or sets the event name.
        /// </summary>
        [JsonProperty("event_name")]
        public string EventName { get; set; }

        /// <summary>
        /// Gets or sets the event start date.
        /// </summary>
        [JsonProperty("event_start_date")]
        public string EventStartDate { get; set; }

        /// <summary>
        /// Gets or sets the event end date.
        /// </summary>
        [JsonProperty("event_end_date")]
        public string EventEndDate { get; set; }

        /// <summary>
        /// Gets or sets the city where the tournament is held.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state or province where the tournament is held.
        /// </summary>
        [JsonProperty("stateprov")]
        public string StateProv { get; set; }

        /// <summary>
        /// Gets or sets the country name where the tournament is held.
        /// </summary>
        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        /// <summary>
        /// Gets or sets the country code where the tournament is held.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the director's ID for the tournament.
        /// </summary>
        [JsonProperty("director_id")]
        public int DirectorId { get; set; }

        /// <summary>
        /// Gets or sets the director's name for the tournament.
        /// </summary>
        [JsonProperty("director_name")]
        public string DirectorName { get; set; }

        /// <summary>
        /// Gets or sets the URL of the profile photo.
        /// </summary>
        [JsonProperty("profile_photo")]
        public string ProfilePhoto { get; set; }
    }
}