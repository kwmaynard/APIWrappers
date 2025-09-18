using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents statistics for a director.
    /// </summary>
    public class DirectorStats
    {
        /// <summary>
        /// Gets or sets the number of tournaments.
        /// </summary>
        [JsonProperty("tournament_count")]
        public int TournamentCount { get; set; }

        /// <summary>
        /// Gets or sets the number of unique locations.
        /// </summary>
        [JsonProperty("unique_location_count")]
        public int UniqueLocationCount { get; set; }

        /// <summary>
        /// Gets or sets the number of women's tournaments.
        /// </summary>
        [JsonProperty("women_tournament_count")]
        public int WomenTournamentCount { get; set; }

        /// <summary>
        /// Gets or sets the number of leagues.
        /// </summary>
        [JsonProperty("league_count")]
        public int LeagueCount { get; set; }

        /// <summary>
        /// Gets or sets the highest value.
        /// </summary>
        [JsonProperty("highest_value")]
        public int HighestValue { get; set; }

        /// <summary>
        /// Gets or sets the average value.
        /// </summary>
        [JsonProperty("average_value")]
        public int AverageValue { get; set; }

        /// <summary>
        /// Gets or sets the total player count.
        /// </summary>
        [JsonProperty("total_player_count")]
        public int TotalPlayerCount { get; set; }

        /// <summary>
        /// Gets or sets the unique player count.
        /// </summary>
        [JsonProperty("unique_player_count")]
        public int UniquePlayerCount { get; set; }

        /// <summary>
        /// Gets or sets the count of first-time players.
        /// </summary>
        [JsonProperty("first_time_player_count")]
        public int FirstTimePlayerCount { get; set; }

        /// <summary>
        /// Gets or sets the count of repeat players.
        /// </summary>
        [JsonProperty("repeat_player_count")]
        public int RepeatPlayerCount { get; set; }

        /// <summary>
        /// Gets or sets the count of the largest event.
        /// </summary>
        [JsonProperty("largest_event_count")]
        public int LargestEventCount { get; set; }

        /// <summary>
        /// Gets or sets the count of single format events.
        /// </summary>
        [JsonProperty("single_format_count")]
        public int SingleFormatCount { get; set; }

        /// <summary>
        /// Gets or sets the count of multiple format events.
        /// </summary>
        [JsonProperty("multiple_format_count")]
        public int MultipleFormatCount { get; set; }

        /// <summary>
        /// Gets or sets the count of unknown format events.
        /// </summary>
        [JsonProperty("unknown_format_count")]
        public int UnknownFormatCount { get; set; }

        /// <summary>
        /// Gets or sets the formats used by the director.
        /// </summary>
        [JsonProperty("formats")]
        public DirectorFormat Formats { get; set; }
    }
}