using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;

namespace coder.controller
{
    public class GHGEntity : ITableEntity
    {
        public GHGEntity(string partit, string row)
        { PartitionKey = partit; RowKey = row; }

        public GHGEntity() { }

        #region ITableEntity Members

        public string ETag{ get; set; }

        public string PartitionKey {get;set;}
        
        public void ReadEntity(IDictionary<string, EntityProperty> properties, Microsoft.WindowsAzure.Storage.OperationContext operationContext)
        {
            throw new NotImplementedException();
        }

        public string RowKey {get;set;}
        
        public DateTimeOffset Timestamp {get;set;}
       

        public IDictionary<string, EntityProperty> WriteEntity(Microsoft.WindowsAzure.Storage.OperationContext operationContext)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

   
}
