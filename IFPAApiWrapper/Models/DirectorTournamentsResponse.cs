using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a response containing tournaments for a director.
    /// </summary>
    public class DirectorTournamentsResponse
    {
        /// <summary>
        /// Gets or sets the director's ID.
        /// </summary>
        [JsonProperty("director_id")]
        public int DirectorId { get; set; }

        /// <summary>
        /// Gets or sets the list of tournaments for the director.
        /// </summary>
        [JsonProperty("tournaments")]
        public List<Tournament> Tournaments { get; set; }
    }
}