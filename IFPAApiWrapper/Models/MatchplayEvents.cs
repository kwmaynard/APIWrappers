using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a matchplay event for a player or tournament.
    /// </summary>
    public class MatchplayEvents
    {
        /// <summary>
        /// Gets or sets the event ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the rating for the event.
        /// </summary>
        [JsonProperty("rating")]
        public double Rating { get; set; }

        /// <summary>
        /// Gets or sets the rank for the event.
        /// </summary>
        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}