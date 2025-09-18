using System.Collections.Generic;

namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents details for a tournament player.
    /// </summary>
    public class TournamentPlayerDetails
    {
        /// <summary>Gets or sets the player status.</summary>
        public string Status { get; set; }

        /// <summary>Gets or sets the seed (nullable).</summary>
        public int? Seed { get; set; }

        /// <summary>Gets or sets the points adjustment.</summary>
        public int PointsAdjustment { get; set; }

        /// <summary>Gets or sets the subscription type.</summary>
        public string Subscription { get; set; }

        /// <summary>Gets or sets the list of labels.</summary>
        public List<string> Labels { get; set; }

        /// <summary>Gets or sets the label color.</summary>
        public string LabelColor { get; set; }
    }
}