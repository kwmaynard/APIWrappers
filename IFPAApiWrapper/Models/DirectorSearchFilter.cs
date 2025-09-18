using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents the filter criteria for searching directors.
    /// </summary>
    public class DirectorSearchFilter
    {
        /// <summary>
        /// Gets or sets the name filter.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the country filter.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the state or province filter.
        /// </summary>
        [JsonProperty("stateprov")]
        public string StateProv { get; set; }

        /// <summary>
        /// Gets or sets the city filter.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }
    }
}