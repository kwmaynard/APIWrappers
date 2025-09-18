using System;
using System.Collections.Generic;

namespace MatchPlayApiWrapper.Models
{
    /// <summary>
    /// Represents the Amazing Race tournament details.
    /// </summary>
    public class AmazingRace
    {
        /// <summary>Gets or sets the tournament ID.</summary>
        public int TournamentId { get; set; }

        /// <summary>Gets or sets the tournament name.</summary>
        public string Name { get; set; }

        /// <summary>Gets or sets the tournament status.</summary>
        public string Status { get; set; }

        /// <summary>Gets or sets the tournament type.</summary>
        public string Type { get; set; }

        /// <summary>Gets or sets the UTC start time.</summary>
        public DateTime? StartUtc { get; set; }

        /// <summary>Gets or sets the local start time.</summary>
        public string StartLocal { get; set; }

        /// <summary>Gets or sets the UTC end time.</summary>
        public DateTime? EndUtc { get; set; }

        /// <summary>Gets or sets the local end time.</summary>
        public string EndLocal { get; set; }

        /// <summary>Gets or sets the completion time.</summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>Gets or sets the organizer ID.</summary>
        public int OrganizerId { get; set; }

        /// <summary>Gets or sets the location ID.</summary>
        public int? LocationId { get; set; }

        /// <summary>Gets or sets the series ID.</summary>
        public int? SeriesId { get; set; }

        /// <summary>Gets or sets the tournament description.</summary>
        public string Description { get; set; }

        /// <summary>Gets or sets the points map.</summary>
        public List<List<int>> PointsMap { get; set; }

        /// <summary>Gets or sets the tiebreaker points map.</summary>
        public List<List<string>> TiebreakerPointsMap { get; set; }

        /// <summary>Gets or sets a value indicating whether this is a test tournament.</summary>
        public bool Test { get; set; }

        /// <summary>Gets or sets the timezone.</summary>
        public string Timezone { get; set; }

        /// <summary>Gets or sets the scorekeeping method.</summary>
        public string Scorekeeping { get; set; }

        /// <summary>Gets or sets the tournament link.</summary>
        public string Link { get; set; }

        /// <summary>Gets or sets the linked tournament ID.</summary>
        public int? LinkedTournamentId { get; set; }

        /// <summary>Gets or sets the estimated TGP.</summary>
        public double? EstimatedTgp { get; set; }

        /// <summary>Gets or sets the organizer details.</summary>
        public Organizer Organizer { get; set; }

        /// <summary>Gets or sets the location details.</summary>
        public Location Location { get; set; }

        /// <summary>Gets or sets the seeding method.</summary>
        public string Seeding { get; set; }

        /// <summary>Gets or sets the first round pairing method.</summary>
        public string FirstRoundPairing { get; set; }

        /// <summary>Gets or sets the pairing method.</summary>
        public string Pairing { get; set; }

        /// <summary>Gets or sets the player order method.</summary>
        public string PlayerOrder { get; set; }

        /// <summary>Gets or sets the arena assignment method.</summary>
        public string ArenaAssignment { get; set; }

        /// <summary>Gets or sets the tournament duration.</summary>
        public int Duration { get; set; }

        /// <summary>Gets or sets the number of games per round.</summary>
        public int GamesPerRound { get; set; }

        /// <summary>Gets or sets the playoffs cutoff.</summary>
        public int PlayoffsCutoff { get; set; }

        /// <summary>Gets or sets tournament suggestions.</summary>
        public string Suggestions { get; set; }

        /// <summary>Gets or sets the tiebreaker method.</summary>
        public string Tiebreaker { get; set; }

        /// <summary>Gets or sets the scoring method.</summary>
        public string Scoring { get; set; }

        /// <summary>Gets or sets the list of rounds.</summary>
        public List<AmazingRaceRound> Rounds { get; set; }

        /// <summary>Gets or sets the list of games.</summary>
        public List<AmazingRaceGame> Games { get; set; }

        /// <summary>Gets or sets the list of queues.</summary>
        public List<AmazingRaceQueue> Queues { get; set; }
    }
}