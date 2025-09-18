using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a director in the IFPA system.
    /// </summary>
    public class Director
    {
        /// <summary>
        /// Gets or sets the director's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the director's country name.
        /// </summary>
        [JsonProperty("profile_photo")]
        public string CountryName { get; set; }

        /// <summary>
        /// Gets or sets the director's country code.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the director's city.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the director's state or province.
        /// </summary>
        [JsonProperty("stateprov")]
        public string StateProv { get; set; }

        /// <summary>
        /// Gets or sets the director's profile photo URL.
        /// </summary>
        [JsonProperty("profile_photo")]
        public string ProfilePhoto { get; set; }
    }
}