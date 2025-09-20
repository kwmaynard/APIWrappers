using Newtonsoft.Json;

namespace OPDBApiWrapper.Models
{
    /// <summary>
    /// Represents the URLs for different sizes of an image in the OPDB API.
    /// </summary>
    public class Urls
    {
        /// <summary>
        /// Gets or sets the URL for the medium size image.
        /// </summary>
        [JsonProperty("medium")]
        public string Medium { get; set; }

        /// <summary>
        /// Gets or sets the URL for the large size image.
        /// </summary>
        [JsonProperty("large")]
        public string Large { get; set; }

        /// <summary>
        /// Gets or sets the URL for the small size image.
        /// </summary>
        [JsonProperty("small")]
        public string Small { get; set; }
    }
}