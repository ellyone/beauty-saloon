using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using Npgsql;

namespace MongoDBApp.Structures
{
    public class PostgresConnection
    {
        public string connString;

        public PostgresConnection()
        {
            string host = "localhost";
            string user = "postgres";
            string database = "beautydb";
            string port = "5432";
            string password = "root";
            connString = String.Format(
                    "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                    host,
                    user,
                    database,
                    port,
                    password);
        }
    }
    public class MongoConnection
    {
        public IMongoDatabase database;

        public MongoConnection()
        {
            string connectionString = "mongodb://localhost:27017";

            MongoClient client = new MongoClient(connectionString);

            database = client.GetDatabase("beautydb");
        }
    }
}
