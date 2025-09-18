using System.Collections.Generic;

namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents a queue for an arena in a tournament.
    /// </summary>
    public class Queue
    {
        /// <summary>Gets or sets the arena ID.</summary>
        public int ArenaId { get; set; }

        /// <summary>Gets or sets the arena name.</summary>
        public string ArenaName { get; set; }

        /// <summary>Gets or sets the list of queue entries.</summary>
        public List<QueueEntry> Entries { get; set; }
    }
}