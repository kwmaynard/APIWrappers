using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a format used by a director in the IFPA system.
    /// </summary>
    public class DirectorFormat
    {
        /// <summary>
        /// Gets or sets the name of the format.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the count of tournaments or events using this format.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}