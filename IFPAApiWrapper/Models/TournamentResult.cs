using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a tournament result for a player.
    /// </summary>
    public class TournamentResult
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
        /// Gets or sets the player's finishing position in the tournament.
        /// </summary>
        [JsonProperty("position")]
        public int Position { get; set; }

        /// <summary>
        /// Gets or sets the points earned by the player in the tournament.
        /// </summary>
        [JsonProperty("points")]
        public double Points { get; set; }

        /// <summary>
        /// Gets or sets the URL of the player's profile photo.
        /// </summary>
        [JsonProperty("profile_photo")]
        public string ProfilePhoto { get; set; }
    }
}