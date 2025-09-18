using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a response containing series information.
    /// </summary>
    public class SeriesResponse
    {
        /// <summary>
        /// Gets or sets the series code.
        /// </summary>
        [JsonProperty("series_code")]
        public string SeriesCode { get; set; }

        /// <summary>
        /// Gets or sets the year of the series.
        /// </summary>
        [JsonProperty("year")]
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets the name of the series.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the region code.
        /// </summary>
        [JsonProperty("region_code")]
        public string RegionCode { get; set; }

        /// <summary>
        /// Gets or sets the count of results returned.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the list of series results.
        /// </summary>
        [JsonProperty("results")]
        public List<SeriesResult> Results { get; set; }
    }
}