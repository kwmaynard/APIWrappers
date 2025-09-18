using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a player's series statistics.
    /// </summary>
    public class PlayerSeries
    {
        /// <summary>
        /// Gets or sets the series code.
        /// </summary>
        [JsonProperty("series_code")]
        public string SeriesCode { get; set; }

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

        /// <summary>
        /// Gets or sets the total points earned in the series.
        /// </summary>
        [JsonProperty("total_points")]
        public double TotalPoints { get; set; }

        /// <summary>
        /// Gets or sets the player's rank in the series.
        /// </summary>
        [JsonProperty("series_rank")]
        public int SeriesRank { get; set; }
    }
}