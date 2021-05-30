using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDBApp.Structures;
using System.Data;
using Npgsql;
using Dapper;

namespace MongoDBApp.Structures
{
    public class EmployeeList
    {
        MongoConnection conn = new MongoConnection();
        public List<Employee> EmployeeData = new List<Employee>();
        public EmployeeList GetEmployee (BsonDocument filter)
        {
            var collection = conn.database.GetCollection<BsonDocument>("employee");
            var people = collection.Find(filter).ToListAsync();

            EmployeeList Emp = new EmployeeList();
            foreach (var doc in people.Result)
            {
                Employee add = new Employee();
                
                foreach (var i in add.Keys)
                {
                    add.document[i] = doc.GetValue(i).ToString();
                }
                Emp.EmployeeData.Add(add);
            }
            return Emp;
        }
    }
    public class Employee
    {
        public Dictionary<string, string> document = new Dictionary<string, string>();
        public List<string> Keys = new List<string>() { "_id", "name", "description", "specialty" };

        public CategoriesList Categories = new CategoriesList();
        public Employee()
        {
            foreach (var i in Keys)
            {
                document.Add(i, null);
            }
        }

        public bool EditEmployee(FilterDefinition<BsonDocument> filter, UpdateDefinition<BsonDocument> update)
        {
            MongoConnection conn = new MongoConnection();
            var collection = conn.database.GetCollection<BsonDocument>("employee");
            try
            {
                collection.UpdateOneAsync(filter, update);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
