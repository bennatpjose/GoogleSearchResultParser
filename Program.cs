using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using MongoDB.Driver;
using MongoDB.Bson;

namespace GoogleResultScraper
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string json = "";

            string[] list = new string[] { };

            var connectionString = "mongodb+srv://admin:password@cluster0.subkd.azure.mongodb.net/PharmaStocks?retryWrites=true&w=majority&connectTimeoutMS=900000";
            var dbclient = new MongoClient(connectionString);
            var database = dbclient.GetDatabase("PharmaStocks");
            var collection = database.GetCollection<BsonDocument>("Stocks");
            
            var docarray = new BsonArray();
            using (var reader = new StreamReader(@"C:\Users\WindowsUser\Downloads\pharmastock.csv"))
            {

                List<string> index = new List<string>();
                List<string> name = new List<string>();
                List<string> stock = new List<string>();
                List<string> country = new List<string>();
                List<string> exchange = new List<string>();
                while (!reader.EndOfStream)
                {
                    var document = new BsonDocument();
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    index.Add(values[0]);
                    name.Add(values[1]);
                    stock.Add(values[2]);
                    country.Add(values[3]);
                    exchange.Add(values[4]);

                    Console.WriteLine(values[1]);
                    document.Add("name", values[1]);
                    Console.WriteLine(values[2]);
                    document.Add("symbol", values[2]);
                    // Get the Json from the API. Dont forget to put your function in async.
                    // You need HttpClient https://www.nuget.org/packages/Microsoft.Net.Http
                    using (var client = new HttpClient())
                    {
                        string url = "https://customsearch.googleapis.com/customsearch/v1?cx=CXKEY&q=" + values[1] + "%20%22news%22 release&safe=off&key=APIKEY";
                        json = await client.GetStringAsync(url);
                    }

                    // Parse the Json string to your object.
                    // You need Json.NET https://www.nuget.org/packages/Newtonsoft.Json/
                    Root r = JsonConvert.DeserializeObject<Root>(json);
                    document.Add("newsite", r.items[0].link);
                    Console.WriteLine(r.items[0].link);
                    await collection.InsertOneAsync(document);
                }

            }
            

        }

    }

}
