using System;
using Newtonsoft.Json;

namespace OPDBApiWrapper.Models
{
    /// <summary>
    /// Represents a changelog entry from the OPDB API.
    /// </summary>
    public class Changelog
    {
        /// <summary>
        /// Gets or sets the unique identifier for the changelog entry.
        /// </summary>
        [JsonProperty("changelog_id")]
        public int ChangelogId { get; set; }

        /// <summary>
        /// Gets or sets the OPDB ID that was deleted in this changelog entry.
        /// </summary>
        [JsonProperty("opdb_id_deleted")]
        public string OpdbIdDeleted { get; set; }

        /// <summary>
        /// Gets or sets the action performed in this changelog entry.
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets the OPDB ID that replaced the deleted ID, if applicable.
        /// </summary>
        [JsonProperty("opdb_id_replacement")]
        public string OpdbIdReplacement { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the changelog entry was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the changelog entry was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
