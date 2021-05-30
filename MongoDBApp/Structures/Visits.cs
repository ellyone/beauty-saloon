using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using Dapper;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDBApp.Structures
{
    public class Visits
    {
        public IEnumerable<Visit> VisitsData;

        public Visits(BsonDocument filter)
        {
            MongoConnection conn = new MongoConnection();
            var collection = conn.database.GetCollection<BsonDocument>("orders");
            var orders = collection.Find(filter).ToListAsync();

            List<Visit> tmp = new List<Visit>();
            foreach (var doc in orders.Result)
            {
                Visit add = new Visit();

                foreach(var i in add.Keys)
                {
                    add.document[i] = doc.GetValue(i).ToString();
                }

                tmp.Add(add);
            }
            VisitsData = tmp;
        }

        public void AddVisit(BsonDocument obj)
        {
            bool can_add = true;
            var filter = BsonDocument.Parse("{employee : ObjectId(\""+ obj.GetValue("employee") + "\"), date : { $lte : ISODate(\"" + obj.GetValue("date") + "\")}}");
            var sort = BsonDocument.Parse("{ date : -1 }");
            MongoConnection conn = new MongoConnection();
            var collection = conn.database.GetCollection<BsonDocument>("orders");
            var employee_visits0 = collection.Find(filter).Sort(sort).Limit(1).ToListAsync();

            filter = BsonDocument.Parse("{employee : ObjectId(\"" + obj.GetValue("employee") + "\"), date : { $gte : ISODate(\"" + obj.GetValue("date") + "\")}}");
            sort = BsonDocument.Parse("{ date : 1}");
            var employee_visits1 = collection.Find(filter).Sort(sort).Limit(1).ToListAsync();

            if (employee_visits0.Result.Count  != 0)
            {
                var duration = employee_visits0.Result[0].GetValue("service").ToString();
                filter = BsonDocument.Parse("{_id : ObjectId(\""+duration+"\")}");
                ServiceList service = new ServiceList();
                service = service.GetService(filter);


                DateTime tmp = DateTime.Parse(employee_visits0.Result[0].GetValue("date").ToString());
                tmp = tmp.AddMinutes(Int32.Parse(service.ServiceData[0].document["duration"]));
                if (tmp > DateTime.Parse(obj.GetValue("date").ToString()))
                {
                    can_add = false;
                }
            }
            if (employee_visits1.Result.Count != 0)
            {
                var duration = obj.GetValue("service").ToString();
                filter = BsonDocument.Parse("{_id : ObjectId(\""+ duration + "\")}");
                var service = new ServiceList();
                service = service.GetService(filter);

                var tmp = DateTime.Parse(obj.GetValue("date").ToString());
                tmp = tmp.AddMinutes(Int32.Parse(service.ServiceData[0].document["duration"]));
                if (tmp > DateTime.Parse(employee_visits1.Result[0].GetValue("date").ToString()))
                {
                    can_add = false;
                }
            }
            if (can_add)
            {
                collection.InsertOne(obj);
            }
        }
    }

    public class Visit
    {
        public List<string> Keys = new List<string>() { "_id", "user", "date", "status", "employee", "service" };
        public Dictionary<string, string> document = new Dictionary<string, string>();

        public Statuses StatusesList;
        public Visit()
        {
            foreach (var i in Keys)
            {
                document.Add(i, null);
            }
        }
    }

    public class Statuses
    {
        public IEnumerable<Status> StatusesData;

        public Statuses()
        {
            PostgresConnection conn = new PostgresConnection();

            using (IDbConnection db = new NpgsqlConnection(conn.connString))
            {
                using (var multi = db.QueryMultiple("taxonomy.Statuses",
                    commandType: CommandType.TableDirect))
                {
                    StatusesData = multi.Read<Status>();
                }
            }
        }

    }

    public class Status
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
