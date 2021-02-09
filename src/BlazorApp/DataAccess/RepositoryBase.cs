using Microsoft.Azure.Cosmos.Table;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

using BlazorApp.Infrastructure;
using BlazorApp.DataAccess.TableStorageEntities;


namespace BlazorApp.DataAccess
{
    public abstract class RepositoryBase<TTableEntity>
        where TTableEntity : TableEntityBase
    {
        private readonly ConfigurationSettings _config;

        public RepositoryBase(ConfigurationSettings config)
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
                Name = "Test thingy 2",
                Intro = "Another thingy of its type in the table"
            };
            _ = await table.ExecuteAsync(TableOperation.Insert(testGenus));
        }

        public async Task<TTableEntity?> SaveAsync(TTableEntity entity)
        {
            return entity.IsNew ? await InsertAsync(entity) : await UpdateAsync(entity);
        }

        public async Task<TTableEntity?> GetByIDAsync(string id)
        {
        }

        private async Task<TTableEntity?> InsertAsync(TTableEntity entity)
        {
            return await GetByIDAsync(entity.RowKey);
        }

        private async Task<TTableEntity?> UpdateAsync(TTableEntity entity)
        {
            return await GetByIDAsync(entity.RowKey);
        }
    }
}