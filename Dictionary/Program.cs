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

        public static Meta GetWebstersWords()
        {
            SearchWords searchwords = new SearchWords();
            var result = new Meta();//will hold our deserialized data
            var webClient = new WebClient();
            byte[] webstersWords = webClient.DownloadData("https://dictionaryapi.com/api/v3/references/collegiate/json/big?key=yourkey");
            var serializer = new JsonSerializer();
            using (var stream = new MemoryStream(webstersWords))
            using (var reader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(reader))
            {
               result = (Meta) (serializer.Deserialize(jsonReader));
            }

            return result;
        }
    }
}
