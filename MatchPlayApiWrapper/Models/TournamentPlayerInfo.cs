namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents a player in a tournament.
    /// </summary>
    public class TournamentPlayerInfo
    {
        /// <summary>Gets or sets the player ID.</summary>
        public int PlayerId { get; set; }

        /// <summary>Gets or sets the player name.</summary>
        public string Name { get; set; }

        /// <summary>Gets or sets the IFPA ID (nullable).</summary>
        public int? IfpaId { get; set; }

        /// <summary>Gets or sets the player status.</summary>
        public string Status { get; set; }

        /// <summary>Gets or sets the organizer ID.</summary>
        public int OrganizerId { get; set; }

        /// <summary>Gets or sets the ID of the user who claimed the player.</summary>
        public int ClaimedBy { get; set; }

        /// <summary>Gets or sets the tournament player details.</summary>
        public TournamentPlayerDetails TournamentPlayer { get; set; }
    }
}