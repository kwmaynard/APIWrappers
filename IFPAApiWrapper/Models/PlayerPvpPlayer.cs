using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a player in a player-vs-player context.
    /// </summary>
    public class PlayerPvpPlayer
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
        /// Gets or sets the player's country code.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the player is excluded.
        /// </summary>
        [JsonProperty("excluded_flag")]
        public bool ExcludedFlag { get; set; }

        /// <summary>
        /// Gets or sets the player's profile photo URL.
        /// </summary>
        [JsonProperty("profile_photo")]
        public string ProfilePhoto { get; set; }
    }
}