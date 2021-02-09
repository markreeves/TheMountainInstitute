namespace BlazorApp.DataAccess.TableStorageEntities
{  
    public class GenusTableEntity : TableEntityBase
    {
        public GenusTableEntity()
            : base("UnModerated")
        {
        }

        public string Name { get; set; } = string.Empty;
        public string Intro { get; set; } = string.Empty;
        public string IntroImageUrl { get; set; } = string.Empty;
    }
}
