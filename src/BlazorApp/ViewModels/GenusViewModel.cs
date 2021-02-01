using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BlazorApp.Models;
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
        private IDataAccess _data;
        private IConfiguration _config;

        public List<GenusModel> Genus { get; set; }
        public List<KingdomModel> Kingdom { get; set; }

        public GenusViewModel(IDataAccess data, IConfiguration config)
        {
            _data = data;
            _config = config;
        }

        public async Task OnInitializedAsync()
        {
            string sql = "select * from genus";
            string sql2 = "select * from kingdom";

            Genus = await _data.LoadData<GenusModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
            Kingdom = await _data.LoadData<KingdomModel, dynamic>(sql2, new { }, _config.GetConnectionString("default"));
        }
        
        public async Task SwitchToKingdomViewAsync()
        {
            //todo: SwitchToKingdomViewAsync should change view to kingdon view and hiode genus view
            throw new NotImplementedException();
        }
    }
}
