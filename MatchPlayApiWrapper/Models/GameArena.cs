namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents an arena in a game.
    /// </summary>
    public class GameArena
    {
        /// <summary>Gets or sets the arena ID.</summary>
        public int ArenaId { get; set; }

        /// <summary>Gets or sets the arena name.</summary>
        public string Name { get; set; }

        /// <summary>Gets or sets the arena status.</summary>
        public string Status { get; set; }

        /// <summary>Gets or sets the OPDB ID.</summary>
        public string OpdbId { get; set; }

        /// <summary>Gets or sets the category ID (nullable).</summary>
        public int? CategoryId { get; set; }

        /// <summary>Gets or sets the organizer ID.</summary>
        public int OrganizerId { get; set; }
    }
}