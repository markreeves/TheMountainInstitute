using System;
namespace BlazorApp.Models
{
    public class SpeciesModel
    {
        public int Id { get; set; } = Constants.UnknownRecordID;
        public string SpeciesName { get; set; } = string.Empty;
        public string SpeciesLatinName { get; set; } = string.Empty;
        public string SpeciesIntro { get; set; } = string.Empty;
        public string SpeciesInfo { get; set; } = string.Empty;
        public string SpeciesImageLink { get; set; } = string.Empty;
        public string SpeciesImageCredit { get; set; } = string.Empty;
        public string SpeciesHabitat { get; set; } = string.Empty;
        public string SpeciesRegions { get; set; } = string.Empty;
        public string SpeciesIdentifiers { get; set; } = string.Empty;
        public string SpeciesGenusType { get; set; } = string.Empty;
        public string SpeciesKingdomType { get; set; } = string.Empty;
        public string SpeciesProtectionType { get; set; } = string.Empty;

        //Todo: Add image support and initialize to empty byte array
        //public byte[] SpeciesImage { get; set; }
    }
}
