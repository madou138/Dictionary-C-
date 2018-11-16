using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Net;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetWebstersWords());
            Console.ReadLine();//keep the console on the screen
        }

        public static List<Meta> GetWebstersWords()
        {
            var result = new List<Meta>();//will hold our deserialized data
            var webClient = new WebClient();
            byte[] webstersWords = webClient.DownloadData("https://dictionaryapi.com/api/v3/references/collegiate/json/big?key=5c3ec0b3-41ae-4bfb-a793-d467709d3d98");
            var serializer = new JsonSerializer();
            using (var stream = new MemoryStream(webstersWords))
            using (var reader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(reader))
            {
               result = serializer.Deserialize<SearchWords>(jsonReader).Metas;
            }

            return result;

        }
    }
}
