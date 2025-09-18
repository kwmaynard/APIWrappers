using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a response containing state ranking information.
    /// </summary>
    public class StateRankingResponse
    {
        /// <summary>
        /// Gets or sets the state or province code.
        /// </summary>
        [JsonProperty("stateprov")]
        public string StateProv { get; set; }

        /// <summary>
        /// Gets or sets the count of results returned.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the list of ranking results for the state.
        /// </summary>
        [JsonProperty("results")]
        public List<RankingResult> Results { get; set; }
    }
}