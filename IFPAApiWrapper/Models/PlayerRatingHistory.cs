using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a player's rating history entry.
    /// </summary>
    public class PlayerRatingHistory
    {
        /// <summary>
        /// Gets or sets the date of the rating entry.
        /// </summary>
        [JsonProperty("rating_date")]
        public string RatingDate { get; set; }

        /// <summary>
        /// Gets or sets the rating value for the entry.
        /// </summary>
        [JsonProperty("rating")]
        public double Rating { get; set; }
    }
}