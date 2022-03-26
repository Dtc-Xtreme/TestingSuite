using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingSuite.Models;

namespace TestingSuite
{
    public static class Tools
    {
        public const string dirOfFiles = @"C:\Users\Dtc-Xtreme\source\repos\TestingJSONParsers\TestingJSONParsers\Files\";
        public const string fileSinglePretty = "MockSinglePretty.json";
        public const string fileSingleCompact = "MockSingleCompact.json";
        public const string fileMulti1000Pretty = "MockMulti1000Pretty.json";
        public const string fileMulti1000Compact = "MockMulti1000Compact.json";
        public const string fileMulti10000Pretty = "MockMulti10000Pretty.json";
        public const string fileMulti10000Compact = "MockMulti10000Compact.json";
        public const string fileMulti100000Pretty = "MockMulti100000Pretty.json";
        public const string fileMulti100000Compact = "MockMulti100000Compact.json";

        public static string LoadJSONFile(string url)
        {
            using (StreamReader r = new StreamReader(url))
            {
                return r.ReadToEnd();
            }
        }

        public static List<T>? CreateMockObjectsX<T>(int amount,char type)
        {
            string choosen = dirOfFiles;

            switch (amount)
            {
                case 1:
                    if (type == 'C')
                    {
                        choosen += fileSingleCompact;
                    }
                    else
                    {
                        choosen += fileSinglePretty;
                    }

                    break;
                case 1000:
                    if (type == 'C')
                    {
                        choosen += fileMulti1000Compact;
                    }
                    else
                    {
                        choosen += fileMulti1000Pretty;
                    }
                    
                    break;
                case 10000:
                    if (type == 'C')
                    {
                        choosen += fileMulti10000Compact;
                    }
                    else
                    {
                        choosen += fileMulti10000Pretty;
                    }
                    break;
                case 100000:
                    if (type == 'C')
                    {
                        choosen += fileMulti100000Compact;
                    }
                    else
                    {
                        choosen += fileMulti100000Pretty;
                    }
                    break;
            }
            try
            {
                return JsonConvert.DeserializeObject<List<T>>(LoadJSONFile(choosen));
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return null;
            }
        }
    }
}
