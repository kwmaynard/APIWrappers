using Newtonsoft.Json;

namespace OPDBApiWrapper.Models
{
    /// <summary>
    /// Represents a simplified machine result from the OPDB API typeahead endpoint.
    /// </summary>
    public class SimpleMachine
    {
        /// <summary>
        /// Gets or sets the unique identifier for the machine.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display text for the machine.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the name of the machine.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets supplementary information about the machine.
        /// </summary>
        [JsonProperty("supplementary")]
        public string Supplementary { get; set; }

        /// <summary>
        /// Gets or sets the display type of the machine.
        /// </summary>
        [JsonProperty("display")]
        public string Display { get; set; }
    }
}