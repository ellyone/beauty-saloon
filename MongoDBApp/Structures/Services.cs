using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDBApp.Structures;
using MongoDB.Bson;
using MongoDB.Driver;


namespace MongoDBApp.Structures
{
    public class ServiceList
    {
        public List<Service> ServiceData = new List<Service>();
        public ServiceList GetService(BsonDocument filter)
        {
            MongoConnection conn = new MongoConnection();
            var collection = conn.database.GetCollection<BsonDocument>("service");
            var services = collection.Find(filter).ToListAsync();

            ServiceList Ser = new ServiceList();
            foreach (var doc in services.Result)
            {
                Service add = new Service();
                {
                    foreach (var i in add.Keys)
                    {
                        add.document[i] = doc.GetValue(i).ToString();
                    }

                    Ser.ServiceData.Add(add);
                }
            }

            return Ser;
        }
    }

    public class Service
    {
        public List<string> Keys = new List<string>() { "_id", "name", "description", "price", "category", "duration" };
        public Dictionary<string, string> document = new Dictionary<string, string>();

        public CategoriesList Categories = new CategoriesList();
        public Service()
        { 
            foreach (var i in Keys)
            {
                document.Add(i, null);
            }
        }
    }
}
