using MongoDB.Bson;
using MongoDB.Driver;

class Program
{
    static void Main(string[] args)
    {
        var client = new MongoClient("mongodb://localhost:27017");
        var database = client.GetDatabase("dummyDatabase");
        var collection = database.GetCollection<BsonDocument>("ArchiveUserTrips");

        var documents = TripSeedData.GetSeedDocuments();

        // Insert documents if not already present
        foreach (var doc in documents)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", doc["_id"]);
            var existing = collection.Find(filter).FirstOrDefault();
            if (existing == null)
            {
                collection.InsertOne(doc);
            }
        }

        Console.WriteLine("Seeding complete.");
    }
}
