using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a player's result in a tournament or event.
    /// </summary>
    public class PlayerResult
    {
        /// <summary>
        /// Gets or sets the name of the tournament.
        /// </summary>
        [JsonProperty("tournament_name")]
        public string TournamentName { get; set; }

        /// <summary>
        /// Gets or sets the tournament ID.
        /// </summary>
        [JsonProperty("tournament_id")]
        public int TournamentId { get; set; }

        /// <summary>
        /// Gets or sets the name of the event.
        /// </summary>
        [JsonProperty("event_name")]
        public string EventName { get; set; }

        /// <summary>
        /// Gets or sets the date of the event.
        /// </summary>
        [JsonProperty("event_date")]
        public string EventDate { get; set; }

        /// <summary>
        /// Gets or sets the country name for the event.
        /// </summary>
        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        /// <summary>
        /// Gets or sets the country code for the event.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the player's position in the event.
        /// </summary>
        [JsonProperty("position")]
        public int Position { get; set; }

        /// <summary>
        /// Gets or sets the original points earned by the player.
        /// </summary>
        [JsonProperty("original_points")]
        public double OriginalPoints { get; set; }

        /// <summary>
        /// Gets or sets the current points earned by the player.
        /// </summary>
        [JsonProperty("current_points")]
        public double CurrentPoints { get; set; }
    }
}