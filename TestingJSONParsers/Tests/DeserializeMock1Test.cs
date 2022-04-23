using BenchmarkDotNet.Attributes;
using TestingSuite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using fastJSON;
using Utf8Json;
using Jil;
using SpanJson;
using System.Text.Json;

namespace TestingSuite.Tests
{
    [MemoryDiagnoser]
    //[SimpleJob(launchCount: 1, warmupCount: 50, targetCount: 25)]
    [SimpleJob(launchCount: 10, warmupCount: 50, targetCount: 25)]

    public class DeserializeMock1Test
    {
        private readonly string dataSimpleJsonCompact;
        private readonly string dataSimpleJsonPretty;
        private readonly string dataJsonMulti1000Compact;
        private readonly string dataJsonMulti1000Pretty;
        private readonly string dataJsonMulti10000Compact;
        private readonly string dataJsonMulti10000Pretty;
        private readonly string dataJsonMulti100000Compact;
        private readonly string dataJsonMulti100000Pretty;

        public DeserializeMock1Test()
        {
            this.dataSimpleJsonCompact = Tools.LoadJSONFile(Tools.dirOfFiles+Tools.fileSingleCompact);
            this.dataSimpleJsonPretty = Tools.LoadJSONFile(Tools.dirOfFiles+Tools.fileSinglePretty);
            this.dataJsonMulti1000Compact = Tools.LoadJSONFile(Tools.dirOfFiles+Tools.fileMulti1000Compact);
            this.dataJsonMulti1000Pretty = Tools.LoadJSONFile(Tools.dirOfFiles+Tools.fileMulti1000Pretty);
            this.dataJsonMulti10000Compact = Tools.LoadJSONFile(Tools.dirOfFiles + Tools.fileMulti10000Compact);
            this.dataJsonMulti10000Pretty = Tools.LoadJSONFile(Tools.dirOfFiles + Tools.fileMulti10000Pretty);
            this.dataJsonMulti100000Compact = Tools.LoadJSONFile(Tools.dirOfFiles + Tools.fileMulti100000Compact);
            this.dataJsonMulti100000Pretty = Tools.LoadJSONFile(Tools.dirOfFiles + Tools.fileMulti100000Pretty);
        }


        // Deserializing Files worden opvoorhand ingelezen om de vershillen in laad tijden te vermijden //
        // System.Text.Json //
        [Benchmark]
        public List<Mock1.Root>? SystemTextJsonDeserializeSingleCompact()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock1.Root>>(dataSimpleJsonCompact);
        }

        [Benchmark]
        public List<Mock1.Root>? SystemTextJsonDeserializeSinglePretty()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock1.Root>>(dataSimpleJsonPretty);
        }

        [Benchmark]
        public List<Mock1.Root>? SystemTextJsonDeserializeMulti1000Compact()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock1.Root>>(dataJsonMulti1000Compact);
        }

        [Benchmark]
        public List<Mock1.Root>? SystemTextJsonDeserializeMulti1000Pretty()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock1.Root>>(dataJsonMulti1000Pretty);
        }

        [Benchmark]
        public List<Mock1.Root>? SystemTextJsonDeserializeMulti10000Compact()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock1.Root>>(dataJsonMulti10000Compact);
        }

        [Benchmark]
        public List<Mock1.Root>? SystemTextJsonDeserializeMulti10000Pretty()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock1.Root>>(dataJsonMulti10000Pretty);
        }

        [Benchmark]
        public List<Mock1.Root>? SystemTextJsonDeserializeMulti100000Compact()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock1.Root>>(dataJsonMulti100000Compact);
        }

        [Benchmark]
        public List<Mock1.Root>? SystemTextJsonDeserializeMulti100000Pretty()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock1.Root>>(dataJsonMulti100000Pretty);
        }


        // Newtonsoft //
        [Benchmark]
        public List<Mock1.Root>? NewtonsoftJsonDeserializeSingleCompact()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock1.Root>>(dataSimpleJsonCompact);
        }

        [Benchmark]
        public List<Mock1.Root>? NewtonsoftJsonDeserializeSinlePretty()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock1.Root>>(dataSimpleJsonPretty);
        }

        [Benchmark]
        public List<Mock1.Root>? NewtonsoftJsonDeserializeMulti1000Compact()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock1.Root>>(dataJsonMulti1000Compact);
        }

        [Benchmark]
        public List<Mock1.Root>? NewtonsoftJsonDeserializeMulti1000Pretty()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock1.Root>>(dataJsonMulti1000Pretty);
        }

        [Benchmark]
        public List<Mock1.Root>? NewtonsoftJsonDeserializeMulti10000Compact()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock1.Root>>(dataJsonMulti10000Compact);
        }

        [Benchmark]
        public List<Mock1.Root>? NewtonsoftJsonDeserializeMulti10000Pretty()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock1.Root>>(dataJsonMulti10000Pretty);
        }

        [Benchmark]
        public List<Mock1.Root>? NewtonsoftJsonDeserializeMulti100000Compact()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock1.Root>>(dataJsonMulti100000Compact);
        }

        [Benchmark]
        public List<Mock1.Root>? NewtonsoftJsonDeserializeMulti100000Pretty()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock1.Root>>(dataJsonMulti100000Pretty);
        }


        // Jill //
        [Benchmark]
        public List<Mock1.Root>? JilJsonDeserializeSingleCompact()
        {
            return Jil.JSON.Deserialize<List<Mock1.Root>>(dataSimpleJsonCompact);
        }

        [Benchmark]
        public List<Mock1.Root>? JilJsonDeserializeSinglePretty()
        {
            return Jil.JSON.Deserialize<List<Mock1.Root>>(dataSimpleJsonPretty);
        }

        [Benchmark]
        public List<Mock1.Root>? JilJsonDeserializeMulti1000Compact()
        {
            return Jil.JSON.Deserialize<List<Mock1.Root>>(dataJsonMulti1000Compact);
        }

        [Benchmark]
        public List<Mock1.Root>? JilJsonDeserializeMulti1000Pretty()
        {
            return Jil.JSON.Deserialize<List<Mock1.Root>>(dataJsonMulti1000Pretty);
        }

        [Benchmark]
        public List<Mock1.Root>? JilJsonDeserializeMulti10000Compact()
        {
            return Jil.JSON.Deserialize<List<Mock1.Root>>(dataJsonMulti10000Compact);
        }

        [Benchmark]
        public List<Mock1.Root>? JilJsonDeserializeMulti10000Pretty()
        {
            return Jil.JSON.Deserialize<List<Mock1.Root>>(dataJsonMulti10000Pretty);
        }

        [Benchmark]
        public List<Mock1.Root>? JilJsonDeserializeMulti100000Compact()
        {
            return Jil.JSON.Deserialize<List<Mock1.Root>>(dataJsonMulti100000Compact);
        }

        [Benchmark]
        public List<Mock1.Root>? JilJsonDeserializeMulti100000Pretty()
        {
            return Jil.JSON.Deserialize<List<Mock1.Root>>(dataJsonMulti100000Pretty);
        }


        // NetJSON //
        [Benchmark]
        public List<Mock1.Root>? NetJSONDeserializeSingleCompact()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock1.Root>>(dataSimpleJsonCompact);
        }

        [Benchmark]
        public List<Mock1.Root>? NetJSONDeserializeSinglePretty()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock1.Root>>(dataSimpleJsonPretty);
        }

        [Benchmark]
        public List<Mock1.Root>? NetJSONDeserializeMulti1000Compact()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock1.Root>>(dataJsonMulti1000Compact);
        }

        [Benchmark]
        public List<Mock1.Root>? NetJSONDeserializeMulti1000Pretty()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock1.Root>>(dataJsonMulti1000Pretty);
        }

        [Benchmark]
        public List<Mock1.Root>? NetJSONDeserializeMulti10000Compact()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock1.Root>>(dataJsonMulti10000Compact);
        }

        [Benchmark]
        public List<Mock1.Root>? NetJSONDeserializeMulti10000Pretty()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock1.Root>>(dataJsonMulti10000Pretty);
        }

        [Benchmark]
        public List<Mock1.Root>? NetJSONDeserializeMulti100000Compact()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock1.Root>>(dataJsonMulti100000Compact);
        }

        [Benchmark]
        public List<Mock1.Root>? NetJSONDeserializeMulti100000Pretty()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock1.Root>>(dataJsonMulti100000Pretty);
        }


        // FastJson //
        [Benchmark]
        public List<Mock1.Root>? FastJsonDeserializeSingleCompact()
        {
            return fastJSON.JSON.ToObject<List<Mock1.Root>>(dataSimpleJsonCompact);
        }

        [Benchmark]
        public List<Mock1.Root>? FastJsonDeserializeSinglePretty()
        {
            return fastJSON.JSON.ToObject<List<Mock1.Root>>(dataSimpleJsonPretty);
        }

        [Benchmark]
        public List<Mock1.Root>? FastJsonDeserializeMulti1000Compact()
        {
            return fastJSON.JSON.ToObject<List<Mock1.Root>>(dataJsonMulti1000Compact);
        }

        [Benchmark]
        public List<Mock1.Root>? FastJsonDeserializeMulti1000Pretty()
        {
            return fastJSON.JSON.ToObject<List<Mock1.Root>>(dataJsonMulti1000Pretty);
        }

        [Benchmark]
        public List<Mock1.Root>? FastJsonDeserializeMulti10000Compact()
        {
            return fastJSON.JSON.ToObject<List<Mock1.Root>>(dataJsonMulti10000Compact);
        }

        [Benchmark]
        public List<Mock1.Root>? FastJsonDeserializeMulti10000Pretty()
        {
            return fastJSON.JSON.ToObject<List<Mock1.Root>>(dataJsonMulti10000Pretty);
        }

        [Benchmark]
        public List<Mock1.Root>? FastJsonDeserializeMulti100000Compact()
        {
            return fastJSON.JSON.ToObject<List<Mock1.Root>>(dataJsonMulti100000Compact);
        }

        [Benchmark]
        public List<Mock1.Root>? FastJsonDeserializeMulti100000Pretty()
        {
            return fastJSON.JSON.ToObject<List<Mock1.Root>>(dataJsonMulti100000Pretty);
        }
    }
}