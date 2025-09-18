using System.Collections.Generic;
using Newtonsoft.Json;

namespace IFPAApiWrapper.Models
{
    /// <summary>
    /// Represents a player-vs-player response between two players.
    /// </summary>
    public class PlayerPvpToPlayerResponse
    {
        /// <summary>
        /// Gets or sets the first player in the PvP response.
        /// </summary>
        [JsonProperty("player_1")]
        public PlayerPvpPlayer Player1 { get; set; }

        /// <summary>
        /// Gets or sets the second player in the PvP response.
        /// </summary>
        [JsonProperty("player_2")]
        public PlayerPvpPlayer Player2 { get; set; }

        /// <summary>
        /// Gets or sets the list of PvP tournaments between the two players.
        /// </summary>
        [JsonProperty("pvp")]
        public List<PlayerPvpTournament> Pvp { get; set; }
    }
}