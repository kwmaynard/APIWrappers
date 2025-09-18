using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a tournament in a player-vs-player context.
    /// </summary>
    public class PlayerPvpTournament
    {
        /// <summary>
        /// Gets or sets the name of the tournament.
        /// </summary>
        [JsonProperty("tournament_name")]
        public string TournamentName { get; set; }

        /// <summary>
        /// Gets or sets the name of the event.
        /// </summary>
        [JsonProperty("event_name")]
        public string EventName { get; set; }

        /// <summary>
        /// Gets or sets the tournament ID.
        /// </summary>
        [JsonProperty("tournament_id")]
        public int TournamentId { get; set; }

        /// <summary>
        /// Gets or sets the end date of the event.
        /// </summary>
        [JsonProperty("event_end_date")]
        public string EventEndDate { get; set; }

        /// <summary>
        /// Gets or sets the country code for the tournament.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the finish position for the tournament.
        /// </summary>
        [JsonProperty("finish_position")]
        public FinishPosition FinishPosition { get; set; }
    }
}