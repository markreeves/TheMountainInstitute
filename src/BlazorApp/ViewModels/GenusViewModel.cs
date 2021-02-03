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
        List<GenusModel> Genus { get; }
        List<KingdomModel> Kingdom { get; }
        List<SpeciesModel> Species { get; }

        bool IsLoading { get; }
        bool ShowKingdom { get; }

        Task OnInitializedAsync();
        //todo: replace with IAsyncRelayCommand from the microsoft MVVM tool kit
        Task SwitchToKingdomViewAsync(GenusModel genus);
    }

    public class GenusViewModel : IGenusViewModel
    {
        private readonly IGenusRepository _genusRepository;
        private readonly IKingdomRepository _KingdomRepository;
        private readonly ISpeciesRepository _SpeciesRepository;

        public List<GenusModel> Genus { get; private set; } = new List<GenusModel>();
        public List<KingdomModel> Kingdom { get; private set; } = new List<KingdomModel>();
        public List<SpeciesModel> Species { get; private set; } = new List<SpeciesModel>();
        public bool IsLoading => Genus.Count == 0;
        public bool ShowKingdom { get; private set; } = false;

        public GenusViewModel(IGenusRepository genusRepository, IKingdomRepository kingdomRepository, ISpeciesRepository SpeciesRepository)
        {
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

        public async Task SwitchToKingdomViewAsync(GenusModel genus)
        {
            //todo: SwitchToKingdomViewAsync should change view to kingdon view and hide genus view
            throw new NotImplementedException();
        }
    }
}
