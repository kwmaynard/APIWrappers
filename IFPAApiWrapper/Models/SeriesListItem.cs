using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents an item in a series list.
    /// </summary>
    public class SeriesListItem
    {
        /// <summary>
        /// Gets or sets the series code.
        /// </summary>
        [JsonProperty("series_code")]
        public string SeriesCode { get; set; }

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
        /// Gets or sets the year of the series.
        /// </summary>
        [JsonProperty("year")]
        public int Year { get; set; }
    }
}