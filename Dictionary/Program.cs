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
            GetWebstersWords();
            Console.ReadLine();//keep the console on the screen
        }

        public static void GetWebstersWords()
        {
            var webClient = new WebClient();
            byte[] webstersWords = webClient.DownloadData("https://dictionaryapi.com/api/v3/references/collegiate/json/big?key=yourkey");
            using (var stream = new MemoryStream(webstersWords))
            using (var reader = new StreamReader(stream))
            {
                reader.ReadToEnd();
            }

        }
    }
}
