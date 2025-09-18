using System.Collections.Generic;

namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents a bank in a tournament.
    /// </summary>
    public class TournamentBank
    {
        /// <summary>Gets or sets the bank ID.</summary>
        public int BankId { get; set; }

        /// <summary>Gets or sets the bank name.</summary>
        public string Name { get; set; }

        /// <summary>Gets or sets the organizer ID.</summary>
        public int OrganizerId { get; set; }

        /// <summary>Gets or sets the list of arena IDs in the bank.</summary>
        public List<int> ArenaIds { get; set; }
    }
}