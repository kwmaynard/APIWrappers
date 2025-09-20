using Newtonsoft.Json;

namespace OPDBApiWrapper.Models
{
    /// <summary>
    /// Represents the available sizes for an image in the OPDB API.
    /// </summary>
    public class Sizes
    {
        /// <summary>
        /// Gets or sets the medium size dimensions.
        /// </summary>
        [JsonProperty("medium")]
        public Size Medium { get; set; }

        /// <summary>
        /// Gets or sets the large size dimensions.
        /// </summary>
        [JsonProperty("large")]
        public Size Large { get; set; }

        /// <summary>
        /// Gets or sets the small size dimensions.
        /// </summary>
        [JsonProperty("small")]
        public Size Small { get; set; }
    }
}