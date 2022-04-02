using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSuite.Tests
{
    [MemoryDiagnoser]
    //[SimpleJob(launchCount: 1, warmupCount: 5, targetCount: 5)]
    [SimpleJob(launchCount: 10, warmupCount: 50, targetCount: 25)]
    public class ArrayTest
    {

        private readonly string[] stringArray;
        private readonly int[] intArray;
        private readonly bool[] boolArray;
        private readonly double[] doubleArray;

        private readonly string stringArrayJson;
        private readonly string intArrayJson;
        private readonly string boolArrayJson;
        private readonly string doubleArrayJson;

        private readonly string[] stringArrayLowerCase;
        private readonly string[] stringArrayCamelCase;
        private readonly string[] stringArrayUpperCase;

        public ArrayTest()
        {
            stringArray = new string[]{"0","1","1","0","0","1","1","0","1","0"};
            intArray = new int[]{0,1,1,0,0,1,1,0,1,0};
            boolArray = new bool[]{false,true,true,false,false,true,true,false,true,false};
            doubleArray = new double[]{0.0,1.0,1.0,0.0,0.0,1.0,1.0,0.0,1.0,0.0};

            stringArrayJson = System.Text.Json.JsonSerializer.Serialize(stringArray);
            intArrayJson = System.Text.Json.JsonSerializer.Serialize(intArray);
            boolArrayJson = System.Text.Json.JsonSerializer.Serialize(boolArray);
            doubleArrayJson = System.Text.Json.JsonSerializer.Serialize(doubleArray);

            stringArrayLowerCase = new string[] { "steven", "natachsa", "frans", "jaden", "dries", "bart", "tom", "paula", "eddy", "maricha" };
            stringArrayCamelCase = new string[] { "Steven", "Natachsa", "Frans", "Jaden", "Dries", "Bart", "Tom", "Paula", "Eddy", "Maricha" };
            stringArrayUpperCase = new string[] { "STEVEN", "NATACHSA", "FRANS", "JADEN", "DRIES", "BART", "TOM", "PAULA", "EDDY", "MARICHA" };
        }

        // Serializing //
        [Benchmark(Baseline = true)]
        public string SerializeStringArray()
        {
            return System.Text.Json.JsonSerializer.Serialize(stringArray);
        }

        [Benchmark]
        public string SerializeIntArray()
        {
            return System.Text.Json.JsonSerializer.Serialize(intArray);
        }

        [Benchmark]
        public string SerializeBoolArray()
        {
            return System.Text.Json.JsonSerializer.Serialize(boolArray);
        }

        [Benchmark]
        public string SerializeDoubleArray()
        {
            return System.Text.Json.JsonSerializer.Serialize(doubleArray);
        }


        // Deserializing //
        [Benchmark]
        public string[]? DeserializeStringArray()
        {
            return System.Text.Json.JsonSerializer.Deserialize<string[]>(stringArrayJson);
        }

        [Benchmark]
        public int[]? DeserializeIntArray()
        {
            return System.Text.Json.JsonSerializer.Deserialize<int[]>(intArrayJson);
        }

        [Benchmark]
        public bool[]? DeserializeBoolArray()
        {
            return System.Text.Json.JsonSerializer.Deserialize<bool[]>(boolArrayJson);
        }

        [Benchmark]
        public double[]? DeserializeDoubleArray()
        {
            return System.Text.Json.JsonSerializer.Deserialize<double[]>(doubleArrayJson);
        }


        //Case Sensitive //
        [Benchmark]
        public string SerializeStringLowerCaseArray()
        {
            return System.Text.Json.JsonSerializer.Serialize(stringArrayLowerCase);
        }

        [Benchmark]
        public string SerializeStrinCamelCaseArray()
        {
            return System.Text.Json.JsonSerializer.Serialize(stringArrayCamelCase);
        }

        [Benchmark]
        public string SerializeStringUpperCaseArray()
        {
            return System.Text.Json.JsonSerializer.Serialize(stringArrayUpperCase);
        }
    }
}
