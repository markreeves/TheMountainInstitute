using System;
namespace BlazorApp.Models
{
    public class SpeciesModel
    {
        public int Id { get; set; }
        public string SpeciesName { get; set; }
        public string SpeciesLatinName { get; set; }
        public string SpeciesIntro { get; set; }
        public string SpeciesInfo { get; set; }
        public string SpeciesImageLink { get; set; }
        public byte[] SpeciesImage { get; set; }
        public string SpeciesImageCredit { get; set; }
        public string SpeciesHabitat { get; set; }
        public string SpeciesRegions { get; set; }
        public string SpeciesIdentifiers { get; set; }
        public string SpeciesGenusType { get; set; }
        public string SpeciesKingdomType { get; set; }
    }
}
