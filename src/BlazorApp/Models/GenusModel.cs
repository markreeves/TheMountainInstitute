using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorApp.Models
{
    public class GenusModel
    {
        public int Id { get; set; }
        public string GenusName { get; set; }
        public string GenusIntro { get; set; }
        public string GenusIntroImageUrl { get; set; }
        public byte[] GenusImage { get; set; }
    }
}
