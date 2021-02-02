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
        private readonly IDataAccessProvider _data;
        private readonly IConfiguration _config;
        private readonly IGenusRepository _genusRepository;
        private readonly IKingdomRepository _KingdomRepository;

        public List<GenusModel> Genus { get; set; }
        public List<KingdomModel> Kingdom { get; set; }

        public GenusViewModel(IDataAccessProvider data, IConfiguration config, IGenusRepository genusRepository, IKingdomRepository kingdomRepository)
        {
            _data = data;
            _config = config;
            _genusRepository = genusRepository;
            _KingdomRepository = kingdomRepository;
        }
        public async Task OnInitializedAsync()
        {
            Genus = await _genusRepository.GetGenusListAsync();
            Kingdom = await _KingdomRepository.GetKingdomListAsync();
        }

        public async Task SwitchToKingdomViewAsync()
        {
            //todo: SwitchToKingdomViewAsync should change view to kingdon view and hide genus view
            throw new NotImplementedException();
        }
    }
}
