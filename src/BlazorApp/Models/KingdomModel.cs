using System;
namespace BlazorApp.Models
{
    public class KingdomModel
    {
        public int Id { get; set; } = Constants.UnknownRecordID;
        public string KingdomName { get; set; } = string.Empty;
        public string KingdomIntro { get; set; } = string.Empty;
        public string KingImageUrl { get; set; } = string.Empty;

        //Todo: Add image support and initialize to empty byte array
        //public byte[] KingdomImage { get; set; }

    }
}
