using System.Collections.Generic;
using Newtonsoft.Json;

namespace OPDBApiWrapper.Models
{
    /// <summary>
    /// Represents a pinball machine in the OPDB API.
    /// </summary>
    public class Machine
    {
        /// <summary>
        /// Gets or sets the OPDB ID of the machine.
        /// </summary>
        [JsonProperty("opdb_id")]
        public string OpdbId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is a machine.
        /// </summary>
        [JsonProperty("is_machine")]
        public bool IsMachine { get; set; }

        /// <summary>
        /// Gets or sets the name of the machine.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the common name of the machine.
        /// </summary>
        [JsonProperty("common_name")]
        public string CommonName { get; set; }

        /// <summary>
        /// Gets or sets the short name of the machine.
        /// </summary>
        [JsonProperty("shortname")]
        public string Shortname { get; set; }

        /// <summary>
        /// Gets or sets the physical machine count.
        /// </summary>
        [JsonProperty("physical_machine")]
        public int PhysicalMachine { get; set; }

        /// <summary>
        /// Gets or sets the IPDB ID of the machine.
        /// </summary>
        [JsonProperty("ipdb_id")]
        public int? IpdbId { get; set; }

        /// <summary>
        /// Gets or sets the manufacture date of the machine.
        /// </summary>
        [JsonProperty("manufacture_date")]
        public string ManufactureDate { get; set; }

        /// <summary>
        /// Gets or sets the manufacturer of the machine.
        /// </summary>
        [JsonProperty("manufacturer")]
        public Manufacturer Manufacturer { get; set; }

        /// <summary>
        /// Gets or sets the type of the machine.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the display type of the machine.
        /// </summary>
        [JsonProperty("display")]
        public string Display { get; set; }

        /// <summary>
        /// Gets or sets the player count for the machine.
        /// </summary>
        [JsonProperty("player_count")]
        public int PlayerCount { get; set; }

        /// <summary>
        /// Gets or sets the features of the machine.
        /// </summary>
        [JsonProperty("features")]
        public List<string> Features { get; set; }

        /// <summary>
        /// Gets or sets the keywords associated with the machine.
        /// </summary>
        [JsonProperty("keywords")]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// Gets or sets the description of the machine.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the machine entry was created.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the machine entry was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the images associated with the machine.
        /// </summary>
        [JsonProperty("images")]
        public List<Image> Images { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this machine is an alias.
        /// </summary>
        [JsonProperty("is_alias")]
        public bool? IsAlias { get; set; }
    }
}
