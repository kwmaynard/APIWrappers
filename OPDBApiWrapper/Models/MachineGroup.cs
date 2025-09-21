using Newtonsoft.Json;

namespace OPDBApiWrapper.Models
{
    /// <summary>
    /// Represents a group of machines in the OPDB API.
    /// </summary>
    public class MachineGroup
    {
        /// <summary>
        /// Gets or sets the OPDB ID of the machine group.
        /// </summary>
        [JsonProperty("opdb_id")]
        public string OpdbId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is a machine group.
        /// </summary>
        [JsonProperty("is_machine_group")]
        public bool IsMachineGroup { get; set; }

        /// <summary>
        /// Gets or sets the name of the machine group.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the short name of the machine group.
        /// </summary>
        [JsonProperty("shortname")]
        public string Shortname { get; set; }

        /// <summary>
        /// Gets or sets the description of the machine group.
        /// </summary>
        [JsonProperty("description")]
        public object Description { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the machine group entry was created.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the machine group entry was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}