using System;

namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents an entry in an arena queue.
    /// </summary>
    public class QueueEntry
    {
        /// <summary>Gets or sets the player ID.</summary>
        public int PlayerId { get; set; }

        /// <summary>Gets or sets the player name.</summary>
        public string PlayerName { get; set; }

        /// <summary>Gets or sets the date and time the player joined the queue.</summary>
        public DateTime JoinedAt { get; set; }
    }
}