using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

using BlazorApp.Models;
using DataLibrary;

namespace BlazorApp.DataAccess
{
    public interface ISpeciesRepository
    {
        Task<List<SpeciesModel>> GetSpeciesListAsync();
    }

    public class SpeciesRepository : ISpeciesRepository
    {
        private readonly IDataAccessProvider _data;
        private readonly IConfiguration _config;

        public SpeciesRepository(IDataAccessProvider data, IConfiguration config)
        {
            _data = data;
            _config = config;
        }

        public async Task<List<SpeciesModel>> GetSpeciesListAsync()
        {
            string sql = "select * from species";

            return await _data.LoadData<SpeciesModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
        }
    }
}
