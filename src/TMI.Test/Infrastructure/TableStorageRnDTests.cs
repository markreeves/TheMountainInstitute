using BlazorApp.Infrastructure;
using FluentAssertions;
using Xunit;
using System.Threading.Tasks;

namespace TMI.Test.Infrastructure
{
    public class TableStorageRnDTests
    {
        private readonly ConfigurationSettings _configurationSettings = new ConfigurationSettings() 
        {
            AzureTableStorageConnectionString = "UseDevelopmentStorage=true"
            //AzureTableStorageConnectionString = "DefaultEndpointsProtocol=http;AccountName=devstoreaccount1;AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==;BlobEndpoint=http://127.0.0.1:10000/devstoreaccount1;QueueEndpoint=http://127.0.0.1:10001/devstoreaccount1;TableEndpoint=http://127.0.0.1:10001/devstoreaccount1;" 
        };

        [Fact]
        public void CheckUnitTestingWorks()
        {
            // Arrange ...
            bool value;

            // Act ...
            value = true;

            // Assert ...
            _ = value.Should().BeTrue();
        }

        [Fact]
        public async Task RnDTrySavingToTableStorage()
        {
            // Arrange ...               
            var tableStorageProvider = new AzureTableStorageProvider(_configurationSettings);

            // Act ...
            await tableStorageProvider.CreateGenusRecordPOCAsync();

            // Assert ...
            // Executes without exception.
        }
    }
}
