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
