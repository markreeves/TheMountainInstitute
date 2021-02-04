using System.Threading.Tasks;
using Microsoft.Azure.Cosmos.Table;

namespace BlazorApp.Infrastructure
{
    public class AzureTableStorageProvider
    {
        private readonly ConfigurationSettings _config;

        public AzureTableStorageProvider(ConfigurationSettings config)
        {
            _config = config;
        }

        public async Task CreateGenusRecordPOCAsync()
        {
            var azureStorageAccount = CloudStorageAccount.Parse(_config.AzureTableStorageConnectionString);

            var client = azureStorageAccount.CreateCloudTableClient();
            var table = client.GetTableReference("Genus");

            _ = await table.CreateIfNotExistsAsync();

            var testGenus = new GenusTableEntity()
            {
                Name = "Test thingy",
                Intro = "The first thingy of its type in the table"
            };
            _ = await table.ExecuteAsync(TableOperation.Insert(testGenus));
        }
    }

    public class GenusTableEntity : TableEntity
    {
        public GenusTableEntity()
        {
            this.PartitionKey = "UnModerated";
            this.RowKey = System.Guid.NewGuid().ToString();
            this.GenusID = this.RowKey;
        }

        public string GenusID { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Intro { get; set; } = string.Empty;
        public string IntroImageUrl { get; set; } = string.Empty;
    }
}
