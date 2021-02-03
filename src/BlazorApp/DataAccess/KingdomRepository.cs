using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

using BlazorApp.Models;
using DataLibrary;

namespace BlazorApp.DataAccess
{
    public interface IKingdomRepository
    {
        Task<List<KingdomModel>> GetKingdomListAsync();
    }

    public class KingdomRepository : IKingdomRepository
    {
        private readonly IDataAccessProvider _data;
        private readonly IConfiguration _config;

        public KingdomRepository(IDataAccessProvider data, IConfiguration config)
        {
            _data = data;
            _config = config;
        }

        public async Task<List<KingdomModel>> GetKingdomListAsync()
        {
            string sql = "select * from kingdom";

            return await _data.LoadData<KingdomModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
        }
    }
}
