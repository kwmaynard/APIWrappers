using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a response containing a list of series.
    /// </summary>
    public class SeriesListResponse
    {
        /// <summary>
        /// Gets or sets the count of series returned.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the list of series items.
        /// </summary>
        [JsonProperty("results")]
        public List<SeriesListItem> Results { get; set; }
    }
}