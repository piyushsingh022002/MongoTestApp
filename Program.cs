using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var client = new MongoClient("mongodb://localhost:27017");
        var database = client.GetDatabase("testdb");
        var collection = database.GetCollection<BsonDocument>("testcollection");

        var doc = new BsonDocument { { "message", "Hello from C# and MongoDB!" } };
        await collection.InsertOneAsync(doc);

        var result = await collection.Find(new BsonDocument()).ToListAsync();
        foreach (var item in result)
        {
            Console.WriteLine(item.ToJson());
        }
    }
}
