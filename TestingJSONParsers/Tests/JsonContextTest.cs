using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingSuite.Models;
using System.Text.Json;


namespace TestingSuite.Tests
{
    [MemoryDiagnoser]
    [SimpleJob(launchCount: 1, warmupCount: 20, targetCount: 20)]
    public class JsonContextTest
    {
        private readonly House[] houses;
        private readonly string houseJson;

        public JsonContextTest()
        {
            House house1 = new House(10, "kraaiestraat", "3530 Houthalen", new Garage(6,"test")); 
            House house2 = new House(7, "kraaiestraat", "3530 Houthalen", new Garage(5, "test"));
            House house3 = new House(9, "kraaiestraat", "3530 Houthalen", new Garage(9, "test"));
            House house4 = new House(8, "kraaiestraat", "3530 Houthalen", new Garage(4, "test"));
            House house5 = new House(2, "kraaiestraat", "3530 Houthalen", new Garage(2, "test"));

            houses = new House[] { house1, house2, house3, house4, house5 };

            houseJson = System.Text.Json.JsonSerializer.Serialize(houses);
        }

        [Benchmark(Baseline = true)]
        public string TestSer1()
        {
            return System.Text.Json.JsonSerializer.Serialize(houses);
        }

        [Benchmark]
        public string TestSer2()
        {
            return System.Text.Json.JsonSerializer.Serialize(houses, HouseJsonSerializerContext.Default.HouseArray);
        }

        [Benchmark(Baseline = true)]
        public House[]? TestDes1()
        {
            return System.Text.Json.JsonSerializer.Deserialize<House[]>(houseJson);
        }

        [Benchmark]
        public House[]? TestDes2()
        {
            return System.Text.Json.JsonSerializer.Deserialize<House[]>(houseJson, HouseJsonSerializerContext.Default.HouseArray);
        }

    }
}
