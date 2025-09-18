using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a series result for a player.
    /// </summary>
    public class SeriesResult
    {
        /// <summary>
        /// Gets or sets the player's ID.
        /// </summary>
        [JsonProperty("player_id")]
        public int PlayerId { get; set; }

        /// <summary>
        /// Gets or sets the player's first name.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the player's last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the total points earned in the series.
        /// </summary>
        [JsonProperty("total_points")]
        public double TotalPoints { get; set; }

        /// <summary>
        /// Gets or sets the player's rank in the series.
        /// </summary>
        [JsonProperty("series_rank")]
        public int SeriesRank { get; set; }

        /// <summary>
        /// Gets or sets the region code.
        /// </summary>
        [JsonProperty("region_code")]
        public string RegionCode { get; set; }

        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the state or province.
        /// </summary>
        [JsonProperty("stateprov")]
        public string StateProv { get; set; }

        /// <summary>
        /// Gets or sets the URL of the player's profile photo.
        /// </summary>
        [JsonProperty("profile_photo_url")]
        public string ProfilePhotoUrl { get; set; }
    }
}