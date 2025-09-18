using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a response containing statistics information.
    /// </summary>
    public class StatsResponse
    {
        /// <summary>
        /// Gets or sets the statistics system.
        /// </summary>
        [JsonProperty("system")]
        public string System { get; set; }

        /// <summary>
        /// Gets or sets the count of results returned.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the list of statistics results.
        /// </summary>
        [JsonProperty("results")]
        public List<StatsResult> Results { get; set; }
    }
}