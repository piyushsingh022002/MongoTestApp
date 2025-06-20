using System;
using System.Collections.Generic;
using MongoDB.Bson;

public static class TripSeedData
{
    public static List<BsonDocument> GetSeedDocuments()
    {
        return new List<BsonDocument>
        {
           new BsonDocument {
        { "_id", new ObjectId("60bfb13c2306b6be1e55c33d") },
        { "TripNumber", 120100927L },
        { "Username", "brbailey" },
        { "TripId", 134112L },
        { "CustomerNumber", "01079" },
        { "LastUpdated", new BsonDateTime(DateTime.Parse("2021-06-08T23:34:41.696+05:30")) }
    },
    new BsonDocument {
        { "_id", new ObjectId("60bfb13c2306b6be1e55c33f") },
        { "TripNumber", 120100927L },
        { "Username", "bsladecek" },
        { "TripId", 134112L },
        { "CustomerNumber", "01079" },
        { "LastUpdated", new BsonDateTime(DateTime.Parse("2021-06-08T23:34:41.696+05:30")) }
    },
    new BsonDocument {
        { "_id", new ObjectId("60bfb13c2306b6be1e55c348") },
        { "TripNumber", 120100927L },
        { "Username", "cbaldauf" },
        { "TripId", 134112L },
        { "CustomerNumber", "01079" },
        { "LastUpdated", new BsonDateTime(DateTime.Parse("2021-06-08T23:34:41.696+05:30")) }
    },
    new BsonDocument {
        { "_id", new ObjectId("60bfb13c2306b6be1e55c349") },
        { "TripNumber", 120100927L },
        { "Username", "cbankston" },
        { "TripId", 134112L },
        { "CustomerNumber", "01079" },
        { "LastUpdated", new BsonDateTime(DateTime.Parse("2021-06-08T23:34:41.696+05:30")) }
    },
    new BsonDocument {
        { "_id", new ObjectId("60bfb13c2306b6be1e55c35b") },
        { "TripNumber", 120100927L },
        { "Username", "dedwards" },
        { "TripId", 134112L },
        { "CustomerNumber", "01079" },
        { "LastUpdated", new BsonDateTime(DateTime.Parse("2021-06-08T23:34:41.696+05:30")) }
    },
    new BsonDocument {
        { "_id", new ObjectId("60bfb13c2306b6be1e55c36c") },
        { "TripNumber", 120100927L },
        { "Username", "dzucca" },
        { "TripId", 134112L },
        { "CustomerNumber", "01079" },
        { "LastUpdated", new BsonDateTime(DateTime.Parse("2021-06-08T23:34:41.696+05:30")) }
    },
    new BsonDocument {
        { "_id", new ObjectId("60bfb13c2306b6be1e55c37d") },
        { "TripNumber", 120100927L },
        { "Username", "francisk" },
        { "TripId", 134112L },
        { "CustomerNumber", "01079" },
        { "LastUpdated", new BsonDateTime(DateTime.Parse("2021-06-08T23:34:41.696+05:30")) }
    },
    new BsonDocument {
        { "_id", new ObjectId("60bfb13c2306b6be1e55c3b8") },
        { "TripNumber", 120100927L },
        { "Username", "keudy" },
        { "TripId", 134112L },
        { "CustomerNumber", "01079" },
        { "LastUpdated", new BsonDateTime(DateTime.Parse("2021-06-08T23:34:41.696+05:30")) }
    },
    new BsonDocument {
        { "_id", new ObjectId("60bfb13c2306b6be1e55c3be") },
        { "TripNumber", 120100927L },
        { "Username", "kmurtaza" },
        { "TripId", 134112L },
        { "CustomerNumber", "01079" },
        { "LastUpdated", new BsonDateTime(DateTime.Parse("2021-06-08T23:34:41.696+05:30")) }
    },
    new BsonDocument {
        { "_id", new ObjectId("60bfb13c2306b6be1e55c320") },
        { "TripNumber", 120100927L },
        { "Username", "afrey" },
        { "TripId", 134112L },
        { "CustomerNumber", "01079" },
        { "LastUpdated", new BsonDateTime(DateTime.Parse("2021-06-08T23:34:41.696+05:30")) }
    },
    new BsonDocument {
        { "_id", new ObjectId("60bfb13c2306b6be1e55c326") },
        { "TripNumber", 120100927L },
        { "Username", "akirkpatrick" },
        { "TripId", 134112L },
        { "CustomerNumber", "01079" },
        { "LastUpdated", new BsonDateTime(DateTime.Parse("2021-06-08T23:34:41.696+05:30")) }
    },
    new BsonDocument {
        { "_id", new ObjectId("60bfb13c2306b6be1e55c332") },
        { "TripNumber", 120100927L },
        { "Username", "automation" },
        { "TripId", 134112L },
        { "CustomerNumber", "01079" },
        { "LastUpdated", new BsonDateTime(DateTime.Parse("2021-06-08T23:34:41.696+05:30")) }
    },
    new BsonDocument {
        { "_id", new ObjectId("60bfb13c2306b6be1e55c33a") },
        { "TripNumber", 120100927L },
        { "Username", "blakesmith" },
        { "TripId", 134112L },
        { "CustomerNumber", "01079" },
        { "LastUpdated", new BsonDateTime(DateTime.Parse("2021-06-08T23:34:41.696+05:30")) }
    },
    new BsonDocument {
        { "_id", new ObjectId("60bfb13c2306b6be1e55c33e") },
        { "TripNumber", 120100927L },
        { "Username", "bshelley" },
        { "TripId", 134112L },
        { "CustomerNumber", "01079" },
        { "LastUpdated", new BsonDateTime(DateTime.Parse("2021-06-08T23:34:41.696+05:30")) }
    },
    new BsonDocument {
        { "_id", new ObjectId("60bfb13c2306b6be1e55c34a") },
        { "TripNumber", 120100927L },
        { "Username", "cbatiste" },
        { "TripId", 134112L },
        { "CustomerNumber", "01079" },
        { "LastUpdated", new BsonDateTime(DateTime.Parse("2021-06-08T23:34:41.696+05:30")) }
    },
    new BsonDocument {
        { "_id", new ObjectId("60bfb13c2306b6be1e55c34f") },
        { "TripNumber", 120100927L },
        { "Username", "cgisclair" },
        { "TripId", 134112L },
        { "CustomerNumber", "01079" },
        { "LastUpdated", new BsonDateTime(DateTime.Parse("2021-06-08T23:34:41.696+05:30")) }
    },
    new BsonDocument {
        { "_id", new ObjectId("60bfb13c2306b6be1e55c35f") },
        { "TripNumber", 120100927L },
        { "Username", "djlewis" },
        { "TripId", 134112L },
        { "CustomerNumber", "01079" },
        { "LastUpdated", new BsonDateTime(DateTime.Parse("2021-06-08T23:34:41.696+05:30")) }
    }
        };
    }
}
