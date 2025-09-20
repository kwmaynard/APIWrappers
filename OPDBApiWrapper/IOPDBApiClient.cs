using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OPDBApiWrapper.Models;

namespace OPDBApiWrapper
{
    /// <summary>
    /// Defines the contract for an OPDB API client.
    /// </summary>
    public interface IOPDBApiClient
    {
        /// <summary>
        /// Gets the changelog from the OPDB API.
        /// </summary>
        /// <returns>A list of <see cref="Changelog"/> objects.</returns>
        Task<List<Changelog>> GetChangelogAsync();

        /// <summary>
        /// Gets the export of machines from the OPDB API.
        /// </summary>
        /// <returns>A list of <see cref="Machine"/> objects.</returns>
        Task<List<Machine>> GetExportAsync();

        /// <summary>
        /// Gets the export of machine groups from the OPDB API.
        /// </summary>
        /// <returns>A list of <see cref="MachineGroup"/> objects.</returns>
        Task<List<MachineGroup>> GetExportGroupsAsync();

        /// <summary>
        /// Gets a machine by its IPDB ID.
        /// </summary>
        /// <param name="ipdbId">The IPDB ID of the machine.</param>
        /// <returns>A <see cref="Machine"/> object.</returns>
        Task<Machine> GetMachineByIpdbIdAsync(int ipdbId);

        /// <summary>
        /// Gets a machine by its OPDB ID.
        /// </summary>
        /// <param name="opdbId">The OPDB ID of the machine.</param>
        /// <returns>A <see cref="Machine"/> object.</returns>
        Task<Machine> GetMachineByOpdbIdAsync(string opdbId);

        /// <summary>
        /// Searches for machines by a search term.
        /// </summary>
        /// <param name="searchTerm">The search term.</param>
        /// <returns>A list of <see cref="Machine"/> objects.</returns>
        Task<List<Machine>> GetSearchResultsAsync(string searchTerm);

        /// <summary>
        /// Gets typeahead search results for machines.
        /// </summary>
        /// <param name="searchTerm">The search term.</param>
        /// <returns>A list of <see cref="SimpleMachine"/> objects.</returns>
        Task<List<SimpleMachine>> GetTypeaheadSearchModelAsync(string searchTerm);
    }
}