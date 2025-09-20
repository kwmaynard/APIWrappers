using Newtonsoft.Json;

namespace OPDBApiWrapper.Models
{
    /// <summary>
    /// Represents the dimensions of an image or object in the OPDB API.
    /// </summary>
    public class Size
    {
        /// <summary>
        /// Gets or sets the width in pixels.
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the height in pixels.
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }
    }
}