using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var client = new MongoClient("mongodb://localhost:27017");
        var database = client.GetDatabase("dummyDatabase");
        var collection = database.GetCollection<BsonDocument>("ArchiveUserTrips");

        // Step 1: Create TTL Index on 'LastUpdated'
        var indexKeys = Builders<BsonDocument>.IndexKeys.Ascending("LastUpdated");
        var indexOptions = new CreateIndexOptions { ExpireAfter = TimeSpan.FromSeconds(60) }; // TTL: 60 seconds
        var indexModel = new CreateIndexModel<BsonDocument>(indexKeys, indexOptions);
        collection.Indexes.CreateOne(indexModel);

        // Step 2: Prepare the seed data (with current time)
        DateTime now = DateTime.UtcNow;

        var documents = new List<BsonDocument>
        {
            new BsonDocument {
                { "_id", new ObjectId("60bfb13c2306b6be1e55c33d") },
                { "TripNumber", 120100927L },
                { "Username", "brbailey" },
                { "TripId", 134112L },
                { "CustomerNumber", "01079" },
                { "LastUpdated", new BsonDateTime(now) }
            },
            new BsonDocument {
                { "_id", new ObjectId("60bfb13c2306b6be1e55c33f") },
                { "TripNumber", 120100927L },
                { "Username", "bsladecek" },
                { "TripId", 134112L },
                { "CustomerNumber", "01079" },
                { "LastUpdated", new BsonDateTime(now) }
            },
            new BsonDocument {
                { "_id", new ObjectId("60bfb13c2306b6be1e55c348") },
                { "TripNumber", 120100927L },
                { "Username", "cbaldauf" },
                { "TripId", 134112L },
                { "CustomerNumber", "01079" },
                { "LastUpdated", new BsonDateTime(now) }
            },
            new BsonDocument {
                { "_id", new ObjectId("60bfb13c2306b6be1e55c349") },
                { "TripNumber", 120100927L },
                { "Username", "cbankston" },
                { "TripId", 134112L },
                { "CustomerNumber", "01079" },
                { "LastUpdated", new BsonDateTime(now) }
            },
            new BsonDocument {
                { "_id", new ObjectId("60bfb13c2306b6be1e55c350") },
                { "TripNumber", 120100927L },
                { "Username", "cdana" },
                { "TripId", 134112L },
                { "CustomerNumber", "01079" },
                { "LastUpdated", new BsonDateTime(now) }
            }
        };

        // Step 3: Insert documents (if not already there)
        foreach (var doc in documents)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", doc["_id"]);
            var existing = collection.Find(filter).FirstOrDefault();
            if (existing == null)
            {
                collection.InsertOne(doc);
                Console.WriteLine($"Inserted: {doc["Username"]}");
            }
            else
            {
                Console.WriteLine($"Already exists: {doc["Username"]}");
            }
        }

        Console.WriteLine("All seed data inserted with current time.");
        Console.WriteLine("TTL is set to 60 seconds. Wait 60s and query the collection.");
    }
}
