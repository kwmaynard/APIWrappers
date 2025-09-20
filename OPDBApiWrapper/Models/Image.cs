using Newtonsoft.Json;

namespace OPDBApiWrapper.Models
{
    /// <summary>
    /// Represents an image associated with a machine in the OPDB API.
    /// </summary>
    public class Image
    {
        /// <summary>
        /// Gets or sets the title of the image.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this image is the primary image.
        /// </summary>
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        /// <summary>
        /// Gets or sets the type of the image.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the URLs for different sizes of the image.
        /// </summary>
        [JsonProperty("urls")]
        public Urls Urls { get; set; }

        /// <summary>
        /// Gets or sets the sizes for the image.
        /// </summary>
        [JsonProperty("sizes")]
        public Sizes Sizes { get; set; }
    }
}