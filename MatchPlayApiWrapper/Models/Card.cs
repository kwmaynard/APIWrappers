using System;
using System.Collections.Generic;

namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents a card in a tournament.
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Gets or sets the card ID.
        /// </summary>
        public int CardId { get; set; }

        /// <summary>
        /// Gets or sets the tournament ID.
        /// </summary>
        public int TournamentId { get; set; }

        /// <summary>
        /// Gets or sets the player ID.
        /// </summary>
        public int PlayerId { get; set; }

        /// <summary>
        /// Gets or sets the status of the card.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is the best game card.
        /// </summary>
        public bool BestGame { get; set; }

        /// <summary>
        /// Gets or sets the creation date and time.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the last update date and time.
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the list of single player games associated with the card.
        /// </summary>
        public List<CardSinglePlayerGame> SinglePlayerGames { get; set; }

        /// <summary>
        /// Gets or sets the list of single player game IDs.
        /// </summary>
        public List<int> SinglePlayerGameIds { get; set; }

        /// <summary>
        /// Gets or sets the list of arena IDs.
        /// </summary>
        public List<int> ArenaIds { get; set; }

        /// <summary>
        /// Gets or sets the points for the card.
        /// </summary>
        public int Points { get; set; }
    }
}