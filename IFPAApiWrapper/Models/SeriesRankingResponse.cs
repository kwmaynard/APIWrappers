using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a response containing series ranking information.
    /// </summary>
    public class SeriesRankingResponse
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
        /// Gets or sets the count of results returned.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the list of ranking results for the series.
        /// </summary>
        [JsonProperty("results")]
        public List<RankingResult> Results { get; set; }
    }
}