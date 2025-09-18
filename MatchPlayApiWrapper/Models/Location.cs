namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents the location of a tournament.
    /// </summary>
    public class Location
    {
        /// <summary>Gets or sets the location ID.</summary>
        public int LocationId { get; set; }

        /// <summary>Gets or sets the location name.</summary>
        public string Name { get; set; }

        /// <summary>Gets or sets the organizer ID (nullable).</summary>
        public int? OrganizerId { get; set; }

        /// <summary>Gets or sets the location status.</summary>
        public string Status { get; set; }
    }
}