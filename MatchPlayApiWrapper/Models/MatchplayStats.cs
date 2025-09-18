using System.Collections.Generic;

namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents matchplay statistics for a tournament.
    /// </summary>
    public class MatchplayStats
    {
        /// <summary>Gets or sets the list of position counts for players.</summary>
        public List<PositionCount> PositionCounts { get; set; }

        /// <summary>Gets or sets the list of arena counts for players.</summary>
        public List<ArenaCount> ArenaCounts { get; set; }

        /// <summary>Gets or sets the list of opponent counts for players.</summary>
        public List<OpponentCount> OpponentCounts { get; set; }
    }
}