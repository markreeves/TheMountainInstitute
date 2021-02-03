using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

using BlazorApp.Models;
using DataLibrary;

namespace BlazorApp.DataAccess
{
    public interface IGenusRepository
    {
        Task<List<GenusModel>> GetGenusListAsync();
    }

    public class GenusRepository : IGenusRepository
    {
        private readonly IDataAccessProvider _data;
        private readonly IConfiguration _config;

        public GenusRepository(IDataAccessProvider data, IConfiguration config)
        {
            _data = data;
            _config = config;
        }

        public async Task<List<GenusModel>> GetGenusListAsync()
        {
            string sql = "select * from genus";

            return await _data.LoadData<GenusModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
        }
    }
}
