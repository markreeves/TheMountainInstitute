using Microsoft.Azure.Cosmos.Table;

namespace BlazorApp.DataAccess.TableStorageEntities
{
    public abstract class TableEntityBase : TableEntity
    {
        public const string EmptyPartitionKey = "";

        public System.Guid? PrimaryKey { get; }
        public bool IsNew => PrimaryKey.HasValue;

        public TableEntityBase(string partitionKey = EmptyPartitionKey)
        {
            this.PartitionKey = partitionKey;
            this.RowKey = System.Guid.NewGuid().ToString();
        }
    }
}
