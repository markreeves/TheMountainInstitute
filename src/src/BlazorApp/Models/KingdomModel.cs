using System;
namespace BlazorApp.Models
{
    public class PlantsModel
    {
        public int Id { get; set; }
        public string KingdomName { get; set; }
        public string KingdomIntro { get; set; }
        public string KingImageUrl { get; set; }
        public byte[] KingdomImage { get; set; }
    }
}
