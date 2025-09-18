using System;

namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents the organizer of a tournament.
    /// </summary>
    public class Organizer
    {
        /// <summary>Gets or sets the user ID.</summary>
        public int UserId { get; set; }

        /// <summary>Gets or sets the organizer name.</summary>
        public string Name { get; set; }

        /// <summary>Gets or sets the IFPA ID (nullable).</summary>
        public int? IfpaId { get; set; }

        /// <summary>Gets or sets the organizer role.</summary>
        public string Role { get; set; }

        /// <summary>Gets or sets the flag.</summary>
        public string Flag { get; set; }

        /// <summary>Gets or sets the location.</summary>
        public string Location { get; set; }

        /// <summary>Gets or sets the pronouns.</summary>
        public string Pronouns { get; set; }

        /// <summary>Gets or sets the initials.</summary>
        public string Initials { get; set; }

        /// <summary>Gets or sets the avatar URL.</summary>
        public string Avatar { get; set; }

        /// <summary>Gets or sets the banner URL.</summary>
        public string Banner { get; set; }

        /// <summary>Gets or sets the tournament avatar URL.</summary>
        public string TournamentAvatar { get; set; }

        /// <summary>Gets or sets the creation date and time (nullable).</summary>
        public DateTime? CreatedAt { get; set; }
    }
}