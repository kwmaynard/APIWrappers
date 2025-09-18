using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents detailed statistics for a player.
    /// </summary>
    public class PlayerStatsDetail
    {
        /// <summary>
        /// Gets or sets the player's current rank.
        /// </summary>
        [JsonProperty("current_rank")]
        public int CurrentRank { get; set; }

        /// <summary>
        /// Gets or sets the player's rank last month.
        /// </summary>
        [JsonProperty("last_month_rank")]
        public int LastMonthRank { get; set; }

        /// <summary>
        /// Gets or sets the player's rank last year.
        /// </summary>
        [JsonProperty("last_year_rank")]
        public int LastYearRank { get; set; }

        /// <summary>
        /// Gets or sets the player's highest rank.
        /// </summary>
        [JsonProperty("highest_rank")]
        public int HighestRank { get; set; }

        /// <summary>
        /// Gets or sets the player's current points.
        /// </summary>
        [JsonProperty("current_points")]
        public double CurrentPoints { get; set; }

        /// <summary>
        /// Gets or sets the player's all-time points.
        /// </summary>
        [JsonProperty("all_time_points")]
        public double AllTimePoints { get; set; }

        /// <summary>
        /// Gets or sets the player's active points.
        /// </summary>
        [JsonProperty("active_points")]
        public double ActivePoints { get; set; }

        /// <summary>
        /// Gets or sets the player's inactive points.
        /// </summary>
        [JsonProperty("inactive_points")]
        public double InactivePoints { get; set; }

        /// <summary>
        /// Gets or sets the player's best finish position.
        /// </summary>
        [JsonProperty("best_finish")]
        public int BestFinish { get; set; }

        /// <summary>
        /// Gets or sets the count of best finishes.
        /// </summary>
        [JsonProperty("best_finish_count")]
        public int BestFinishCount { get; set; }

        /// <summary>
        /// Gets or sets the player's average finish position.
        /// </summary>
        [JsonProperty("average_finish")]
        public double AverageFinish { get; set; }

        /// <summary>
        /// Gets or sets the player's average finish position last year.
        /// </summary>
        [JsonProperty("average_finish_last_year")]
        public double AverageFinishLastYear { get; set; }

        /// <summary>
        /// Gets or sets the total number of events played all time.
        /// </summary>
        [JsonProperty("total_events_all_time")]
        public int TotalEventsAllTime { get; set; }

        /// <summary>
        /// Gets or sets the total number of active events played.
        /// </summary>
        [JsonProperty("total_active_events")]
        public int TotalActiveEvents { get; set; }

        /// <summary>
        /// Gets or sets the total number of away events played.
        /// </summary>
        [JsonProperty("total_events_away")]
        public int TotalEventsAway { get; set; }

        /// <summary>
        /// Gets or sets the total number of wins in the last 3 years.
        /// </summary>
        [JsonProperty("total_wins_last_3_years")]
        public int TotalWinsLast3Years { get; set; }

        /// <summary>
        /// Gets or sets the total number of top 3 finishes in the last 3 years.
        /// </summary>
        [JsonProperty("top_3_last_3_years")]
        public int Top3Last3Years { get; set; }

        /// <summary>
        /// Gets or sets the total number of top 10 finishes in the last 3 years.
        /// </summary>
        [JsonProperty("top_10_last_3_years")]
        public int Top10Last3Years { get; set; }

        /// <summary>
        /// Gets or sets the player's ratings rank.
        /// </summary>
        [JsonProperty("ratings_rank")]
        public int RatingsRank { get; set; }

        /// <summary>
        /// Gets or sets the player's ratings value.
        /// </summary>
        [JsonProperty("ratings_value")]
        public double RatingsValue { get; set; }

        /// <summary>
        /// Gets or sets the player's efficiency rank.
        /// </summary>
        [JsonProperty("efficiency_rank")]
        public int EfficiencyRank { get; set; }

        /// <summary>
        /// Gets or sets the player's efficiency value.
        /// </summary>
        [JsonProperty("efficiency_value")]
        public double EfficiencyValue { get; set; }
    }
}