using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a tournament in the IFPA system.
    /// </summary>
    public class Tournament
    {
        /// <summary>
        /// Gets the unique identifier for the tournament.
        /// </summary>
        [JsonProperty("tournament_id")]
        public string TournamentId { get; internal set; }

        /// <summary>
        /// Gets the name of the tournament.
        /// </summary>
        [JsonProperty("tournament_name")]
        public string TournamentName { get; internal set; }

        /// <summary>
        /// Gets the type of the tournament.
        /// </summary>
        [JsonProperty("tournament_type")]
        public string TournamentType { get; internal set; }

        /// <summary>
        /// Gets the prestige flag for the tournament.
        /// </summary>
        [JsonProperty("prestige_flag")]
        public string PrestigeFlag { get; internal set; }

        /// <summary>
        /// Gets the periodic flag for the tournament.
        /// </summary>
        [JsonProperty("periodic_flag")]
        public string PeriodicFlag { get; internal set; }

        /// <summary>
        /// Gets the city where the tournament is held.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; internal set; }

        /// <summary>
        /// Gets the state where the tournament is held.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; internal set; }

        /// <summary>
        /// Gets the country name where the tournament is held.
        /// </summary>
        [JsonProperty("country_name")]
        public string CountryName { get; internal set; }

        /// <summary>
        /// Gets the contact name for the tournament.
        /// </summary>
        [JsonProperty("contact_name")]
        public string ContactName { get; internal set; }

        /// <summary>
        /// Gets the website URL for the tournament.
        /// </summary>
        [JsonProperty("website")]
        public string Website { get; internal set; }

        /// <summary>
        /// Gets the list of events associated with the tournament.
        /// </summary>
        [JsonProperty("events")]
        public List<Event> Events { get; internal set; }

        /// <summary>
        /// Gets the name of the event.
        /// </summary>
        [JsonProperty("event_name")]
        public string EventName { get; internal set; }

        /// <summary>
        /// Gets the date of the event.
        /// </summary>
        [JsonProperty("event_date")]
        public string EventDate { get; internal set; }

        /// <summary>
        /// Gets the periodic count for the tournament.
        /// </summary>
        [JsonProperty("periodic_count")]
        public int? PeriodicCount { get; internal set; }

        /// <summary>
        /// Gets the rating strength for the tournament.
        /// </summary>
        [JsonProperty("rating_strength")]
        public string RatingStrength { get; internal set; }

        /// <summary>
        /// Gets the ranking strength for the tournament.
        /// </summary>
        [JsonProperty("ranking_strength")]
        public string RankingStrength { get; internal set; }

        /// <summary>
        /// Gets the base value for the tournament.
        /// </summary>
        [JsonProperty("base_value")]
        public string BaseValue { get; internal set; }

        /// <summary>
        /// Gets the event value for the tournament.
        /// </summary>
        [JsonProperty("event_value")]
        public string EventValue { get; internal set; }

        /// <summary>
        /// Gets the list of tournament results.
        /// </summary>
        [JsonProperty("results")]
        public List<TournamentResult> Results { get; internal set; }

        /// <summary>
        /// Gets the name of the winner.
        /// </summary>
        [JsonProperty("winner_name")]
        public string WinnerName { get; internal set; }

        /// <summary>
        /// Gets the player ID of the winner.
        /// </summary>
        [JsonProperty("winner_player_id")]
        public string WinnerPlayerId { get; internal set; }

        /// <summary>
        /// Gets the country code where the tournament is held.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; internal set; }

        /// <summary>
        /// Gets the number of players in the tournament.
        /// </summary>
        [JsonProperty("player_count")]
        public string PlayerCount { get; internal set; }

        /// <summary>
        /// Gets the number of events in the tournament.
        /// </summary>
        [JsonProperty("event_count")]
        public string EventCount { get; internal set; }

        /// <summary>
        /// Gets the type of the event.
        /// </summary>
        [JsonProperty("event_type")]
        public string EventType { get; internal set; }

        /// <summary>
        /// Gets the date of the last event in the tournament.
        /// </summary>
        [JsonProperty("last_event_date")]
        public string LastEventDate { get; internal set; }
    }
}