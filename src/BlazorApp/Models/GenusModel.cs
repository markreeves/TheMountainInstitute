using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorApp.Models
{
    public class GenusModel
    {
        public int Id { get; set; } = Constants.UnknownRecordID;
        public string GenusName { get; set; } = string.Empty;
        public string GenusIntro { get; set; } = string.Empty;
        public string GenusIntroImageUrl { get; set; } = string.Empty;

        //Todo: Add image support and initialize to empty byte array
        //public byte[] GenusImage { get; set; }
    }
}
