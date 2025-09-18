namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents the location of a Max Matchplay tournament.
    /// </summary>
    public class MaxMatchplayLocation
    {
        /// <summary>Gets or sets the location ID.</summary>
        public int LocationId { get; set; }

        /// <summary>Gets or sets the Scorbit venue ID (nullable).</summary>
        public int? ScorbitVenueId { get; set; }

        /// <summary>Gets or sets the Pinballmap ID (nullable).</summary>
        public int? PinballmapId { get; set; }

        /// <summary>Gets or sets the location name.</summary>
        public string Name { get; set; }

        /// <summary>Gets or sets the organizer ID.</summary>
        public int OrganizerId { get; set; }

        /// <summary>Gets or sets the location status.</summary>
        public string Status { get; set; }

        /// <summary>Gets or sets the address.</summary>
        public string Address { get; set; }
    }
}