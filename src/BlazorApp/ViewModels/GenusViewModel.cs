using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
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
        List<SpeciesModel> Species { get; set; }

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
        private readonly ISpeciesRepository _SpeciesRepository;

        public List<GenusModel> Genus { get; set; }
        public List<KingdomModel> Kingdom { get; set; }
        public List<SpeciesModel> Species { get; set; }

        public GenusViewModel(IDataAccessProvider data, IConfiguration config, IGenusRepository genusRepository, IKingdomRepository kingdomRepository, ISpeciesRepository SpeciesRepository)
        {
            _data = data;
            _config = config;
            _genusRepository = genusRepository;
            _KingdomRepository = kingdomRepository;
            _SpeciesRepository = SpeciesRepository;
        }
        public async Task OnInitializedAsync()
        {
            Genus = await _genusRepository.GetGenusListAsync();
            Kingdom = await _KingdomRepository.GetKingdomListAsync();
            Species = await _SpeciesRepository.GetSpeciesListAsync();
        }

        public async Task SwitchToKingdomViewAsync()
        {
            //todo: SwitchToKingdomViewAsync should change view to kingdon view and hide genus view
            throw new NotImplementedException();
        }
    }
}
