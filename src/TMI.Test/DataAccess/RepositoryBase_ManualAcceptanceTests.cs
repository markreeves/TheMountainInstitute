using BlazorApp.Infrastructure;
using FluentAssertions;
using Xunit;
using System.Threading.Tasks;
using BlazorApp.DataAccess.TableStorageEntities;
using BlazorApp.DataAccess;
using Moq;

namespace TMI.Test.DataAccess
{
    public class RepositoryBase_ManualAcceptanceTests
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
            var repo = new TestPersonRepository(_configurationSettings);

            // Act ...
            await repo.CreateGenusRecordPOCAsync();

            // Assert ...
            // Executes without exception.
        }


        [Fact]
        public async Task RnDRepoSaveNewToTableStorage()
        {
            // Arrange ...
            var repo = new TestPersonRepository(_configurationSettings);
            var entity = new PersonTableEntity();

            // Act ...
            var result = await repo.SaveAsync(entity);

            // Assert ...
            // Executes without exception.
        }
    }

    public class TestPersonRepository : RepositoryBase<PersonTableEntity>
    {
        public TestPersonRepository(ConfigurationSettings config)
            : base(config)
        {
        }        
    }

    public class PersonTableEntity : TableEntityBase
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; } = 0;
    }
}
