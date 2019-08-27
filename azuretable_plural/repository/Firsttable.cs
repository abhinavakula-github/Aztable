using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Azure.Cosmos.Table;

namespace ConnectingAzTable_plural.Repository
{
    
    public class Firsttable
    {

        private CloudTable cloudtable;
        public Firsttable()
        {

            CloudStorageAccount storageaccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=firstrgdiag864;AccountKey=+KRMIAifAq866ab3UbK5lEkSRdT91dc9mUabVyIjIusrLIYIBwEJTQc1NmNcPzfrPijrHau58EoGRBdVWXpoXw==;EndpointSuffix=core.windows.net");

            CloudTableClient tableclient = storageaccount.CreateCloudTableClient();

            cloudtable = tableclient.GetTableReference("FirstTable");

        }

        public IEnumerable<Firsttableentity> All()
        {
            DateTimeOffset date1 = new DateTimeOffset(new DateTime(550, 1, 1),
                                                TimeSpan.Zero);

            var query = new TableQuery<Firsttableentity>().Where(TableQuery.GenerateFilterConditionForDate(
                nameof(Firsttableentity.Timestamp), QueryComparisons.GreaterThan,date1));

            var entities = cloudtable.ExecuteQuery(query);

            return entities;
        }

        public class Firsttableentity : TableEntity
        {
            public string Name { get; set; }

            public string Email { get; set; }

            public int PhoneNum { get; set; }

            public int timestamp { get; set; }


        }
    }

}