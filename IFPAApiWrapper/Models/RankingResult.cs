using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a ranking result for a player.
    /// </summary>
    public class RankingResult
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
        /// Gets or sets the player's country name.
        /// </summary>
        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        /// <summary>
        /// Gets or sets the player's country code.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the player's city.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the player's state or province.
        /// </summary>
        [JsonProperty("stateprov")]
        public string StateProv { get; set; }

        /// <summary>
        /// Gets or sets the player's WPPR rank.
        /// </summary>
        [JsonProperty("wppr_rank")]
        public int WpprRank { get; set; }

        /// <summary>
        /// Gets or sets the player's rating value.
        /// </summary>
        [JsonProperty("rating_value")]
        public double RatingValue { get; set; }

        /// <summary>
        /// Gets or sets the URL of the player's profile photo.
        /// </summary>
        [JsonProperty("profile_photo_url")]
        public string ProfilePhotoUrl { get; set; }
    }
}