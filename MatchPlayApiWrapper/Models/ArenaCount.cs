using System.Collections.Generic;

namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents the count of arenas for a player.
    /// </summary>
    public class ArenaCount
    {
        /// <summary>Gets or sets the player ID.</summary>
        public int PlayerId { get; set; }

        /// <summary>Gets or sets the dictionary of arena counts (arena ID -> count).</summary>
        public Dictionary<int, int> Arenas { get; set; }
    }
}