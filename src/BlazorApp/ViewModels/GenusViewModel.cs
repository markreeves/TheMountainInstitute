using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

using BlazorApp.Models;
using BlazorApp.DataAccess;

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
        void SwitchToKingdomViewAsync(GenusModel genus);
    }

    public class GenusViewModel : IGenusViewModel
    {
        private readonly IGenusRepository _genusRepository;
        private readonly IKingdomRepository _KingdomRepository;
        private readonly ISpeciesRepository _SpeciesRepository;

        private readonly List<KingdomModel> _allKingdoms = new List<KingdomModel>();

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
            _allKingdoms.AddRange(Kingdom);
        }

        public void SwitchToKingdomViewAsync(GenusModel genus)
        {
            //Kingdom = _allKingdoms.Where(x => x.KingdomGenusType == genus.GenusName).ToList();
            ShowKingdom = true;
        }
    }
}
