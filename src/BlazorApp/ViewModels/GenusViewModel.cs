using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BlazorApp.Models;
using BlazorApp.DataAccess;
using DataLibrary;

namespace BlazorApp.ViewModels
{
    public interface IGenusViewModel
    {
        List<GenusModel> Genus { get; set; }
        List<KingdomModel> Kingdom { get; set; }

        Task OnInitializedAsync();
        //todo: replace with IAsyncRelayCommand from the microsoft MVVM tool kit
        Task SwitchToKingdomViewAsync();
    }

    public class GenusViewModel : IGenusViewModel
    {
        private IDataAccessProvider _data;
        private IConfiguration _config;
        private IGenusRepository _genusRepository;

        public List<GenusModel> Genus { get; set; }
        public List<KingdomModel> Kingdom { get; set; }

        public GenusViewModel(IDataAccessProvider data, IConfiguration config, IGenusRepository genusRepository)
        {
            _data = data;
            _config = config;
            _genusRepository = genusRepository;
        }

        public async Task OnInitializedAsync()
        {
            Genus = await _genusRepository.GetGenusListAsync();

            string sql2 = "select * from kingdom";

            Kingdom = await _data.LoadData<KingdomModel, dynamic>(sql2, new { }, _config.GetConnectionString("default"));
        }

        public async Task SwitchToKingdomViewAsync()
        {
            //todo: SwitchToKingdomViewAsync should change view to kingdon view and hiode genus view
            throw new NotImplementedException();
        }
    }
}
