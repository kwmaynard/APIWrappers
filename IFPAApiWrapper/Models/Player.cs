using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a player in the IFPA system.
    /// </summary>
    public class Player
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
        /// Gets or sets the player's initials.
        /// </summary>
        [JsonProperty("initials")]
        public string Initials { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the player is excluded.
        /// </summary>
        [JsonProperty("excluded_flag")]
        public bool ExcludedFlag { get; set; }

        /// <summary>
        /// Gets or sets the player's age.
        /// </summary>
        [JsonProperty("age")]
        public int? Age { get; set; }

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
        /// Gets or sets a value indicating whether the player is IFPA registered.
        /// </summary>
        [JsonProperty("ifpa_registered")]
        public bool IfpaRegistered { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the player is flagged as a women's player.
        /// </summary>
        [JsonProperty("womens_flag")]
        public bool WomensFlag { get; set; }

        /// <summary>
        /// Gets or sets the player's profile photo URL.
        /// </summary>
        [JsonProperty("profile_photo")]
        public string ProfilePhoto { get; set; }

        /// <summary>
        /// Gets or sets the player's matchplay events.
        /// </summary>
        [JsonProperty("matchplay_events")]
        public MatchplayEvents MatchplayEvents { get; set; }

        /// <summary>
        /// Gets or sets the player's Twitch username.
        /// </summary>
        [JsonProperty("twitch_username")]
        public string TwitchUsername { get; set; }

        /// <summary>
        /// Gets or sets the player's Pinside username.
        /// </summary>
        [JsonProperty("pinside_username")]
        public string PinsideUsername { get; set; }

        /// <summary>
        /// Gets or sets the player's statistics details.
        /// </summary>
        [JsonProperty("player_stats")]
        public PlayerStatsDetail PlayerStats { get; set; }

        /// <summary>
        /// Gets or sets the player's series information.
        /// </summary>
        [JsonProperty("series")]
        public PlayerSeries Series { get; set; }
    }
}