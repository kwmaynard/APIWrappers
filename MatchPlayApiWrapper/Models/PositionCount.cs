using System.Collections.Generic;

namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents the count of positions for a player.
    /// </summary>
    public class PositionCount
    {
        /// <summary>Gets or sets the player ID.</summary>
        public int PlayerId { get; set; }

        /// <summary>Gets or sets the dictionary of position counts (position -> count).</summary>
        public Dictionary<int, int> Positions { get; set; }
    }
}