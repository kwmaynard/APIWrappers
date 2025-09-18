namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents a top score for a player in an arena.
    /// </summary>
    public class TopScore
    {
        /// <summary>Gets or sets the arena ID.</summary>
        public int ArenaId { get; set; }

        /// <summary>Gets or sets the player ID.</summary>
        public int PlayerId { get; set; }

        /// <summary>Gets or sets the player name.</summary>
        public string PlayerName { get; set; }

        /// <summary>Gets or sets the score achieved by the player.</summary>
        public int Score { get; set; }

        /// <summary>Gets or sets the rank of the score.</summary>
        public int Rank { get; set; }
    }
}