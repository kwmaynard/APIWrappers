using System.Collections.Generic;

namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents the count of opponents for a player.
    /// </summary>
    public class OpponentCount
    {
        /// <summary>Gets or sets the player ID.</summary>
        public int PlayerId { get; set; }

        /// <summary>Gets or sets the dictionary of opponent counts (opponent ID -> count).</summary>
        public Dictionary<int, int> Opponents { get; set; }
    }
}