using Newtonsoft.Json;

namespace OPDBApiWrapper.Models
{
    /// <summary>
    /// Represents a manufacturer in the OPDB API.
    /// </summary>
    public class Manufacturer
    {
        /// <summary>
        /// Gets or sets the unique identifier for the manufacturer.
        /// </summary>
        [JsonProperty("manufacturer_id")]
        public int ManufacturerId { get; set; }

        /// <summary>
        /// Gets or sets the short name of the manufacturer.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the full name of the manufacturer.
        /// </summary>
        [JsonProperty("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the manufacturer entry was created.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the manufacturer entry was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}