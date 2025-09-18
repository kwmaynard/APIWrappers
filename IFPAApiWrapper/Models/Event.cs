using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents an event in the IFPA system.
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Gets or sets the date of the event.
        /// </summary>
        [JsonProperty("event_date")]
        public string EventDate { get; internal set; }

        /// <summary>
        /// Gets or sets the player ID of the event winner.
        /// </summary>
        [JsonProperty("winner_player_id")]
        public string WinnerPlayerId { get; internal set; }

        /// <summary>
        /// Gets or sets the first name of the event winner.
        /// </summary>
        [JsonProperty("winner_first_name")]
        public string WinnerFirstName { get; internal set; }

        /// <summary>
        /// Gets or sets the last name of the event winner.
        /// </summary>
        [JsonProperty("winner_last_name")]
        public string WinnerLastName { get; internal set; }
    }
}