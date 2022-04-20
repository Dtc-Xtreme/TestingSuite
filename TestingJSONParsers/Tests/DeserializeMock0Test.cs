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

    public class DeserializeMock0Test
    {
        private readonly string dataSimpleJsonCompact;
        private readonly string dataSimpleJsonPretty;
        private readonly string dataJsonMulti1000Compact;
        private readonly string dataJsonMulti1000Pretty;
        private readonly string dataJsonMulti10000Compact;
        private readonly string dataJsonMulti10000Pretty;
        private readonly string dataJsonMulti100000Compact;
        private readonly string dataJsonMulti100000Pretty;

        public DeserializeMock0Test()
        {
            this.dataSimpleJsonCompact = Tools.LoadJSONFile(Tools.dirOfFiles+Tools.fileSimpleSingleCompact);
            this.dataSimpleJsonPretty = Tools.LoadJSONFile(Tools.dirOfFiles+Tools.fileSimpleSinglePretty);
            this.dataJsonMulti1000Compact = Tools.LoadJSONFile(Tools.dirOfFiles+Tools.fileSimpleMulti1000Compact);
            this.dataJsonMulti1000Pretty = Tools.LoadJSONFile(Tools.dirOfFiles+Tools.fileSimpleMulti1000Pretty);
            this.dataJsonMulti10000Compact = Tools.LoadJSONFile(Tools.dirOfFiles + Tools.fileSimpleMulti10000Compact);
            this.dataJsonMulti10000Pretty = Tools.LoadJSONFile(Tools.dirOfFiles + Tools.fileSimpleMulti10000Pretty);
            this.dataJsonMulti100000Compact = Tools.LoadJSONFile(Tools.dirOfFiles + Tools.fileSimpleMulti100000Compact);
            this.dataJsonMulti100000Pretty = Tools.LoadJSONFile(Tools.dirOfFiles + Tools.fileSimpleMulti100000Pretty);
        }


        // Deserializing Files worden opvoorhand ingelezen om de vershillen in laad tijden te vermijden //
        // System.Text.Json //
        [Benchmark]
        public List<Mock0>? SystemTextJsonDeserializeSimpleSingleCompact()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock0>>(dataSimpleJsonCompact);
        }

        [Benchmark]
        public List<Mock0>? SystemTextJsonDeserializeSimpleSinglePretty()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock0>>(dataSimpleJsonPretty);
        }

        [Benchmark]
        public List<Mock0>? SystemTextJsonDeserializeSimpleMulti1000Compact()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock0>>(dataJsonMulti1000Compact);
        }

        [Benchmark]
        public List<Mock0>? SystemTextJsonDeserializeSimpleMulti1000Pretty()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock0>>(dataJsonMulti1000Pretty);
        }

        [Benchmark]
        public List<Mock0>? SystemTextJsonDeserializeSimpleMulti10000Compact()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock0>>(dataJsonMulti10000Compact);
        }

        [Benchmark]
        public List<Mock0>? SystemTextJsonDeserializeSimpleMulti10000Pretty()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock0>>(dataJsonMulti10000Pretty);
        }

        [Benchmark]
        public List<Mock0>? SystemTextJsonDeserializeSimpleMulti100000Compact()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock0>>(dataJsonMulti100000Compact);
        }

        [Benchmark]
        public List<Mock0>? SystemTextJsonDeserializeSimpleMulti100000Pretty()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock0>>(dataJsonMulti100000Pretty);
        }


        // Newtonsoft //
        [Benchmark]
        public List<Mock0>? NewtonsoftJsonDeserializeSimpleSingleCompact()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock0>>(dataSimpleJsonCompact);
        }

        [Benchmark]
        public List<Mock0>? NewtonsoftJsonDeserializeSimpleSinlePretty()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock0>>(dataSimpleJsonPretty);
        }

        [Benchmark]
        public List<Mock0>? NewtonsoftJsonDeserializeSimpleMulti1000Compact()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock0>>(dataJsonMulti1000Compact);
        }

        [Benchmark]
        public List<Mock0>? NewtonsoftJsonDeserializeSimpleMulti1000Pretty()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock0>>(dataJsonMulti1000Pretty);
        }

        [Benchmark]
        public List<Mock0>? NewtonsoftJsonDeserializeSimpleMulti10000Compact()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock0>>(dataJsonMulti10000Compact);
        }

        [Benchmark]
        public List<Mock0>? NewtonsoftJsonDeserializeSimpleMulti10000Pretty()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock0>>(dataJsonMulti10000Pretty);
        }

        [Benchmark]
        public List<Mock0>? NewtonsoftJsonDeserializeSimpleMulti100000Compact()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock0>>(dataJsonMulti100000Compact);
        }

        [Benchmark]
        public List<Mock0>? NewtonsoftJsonDeserializeSimpleMulti100000Pretty()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock0>>(dataJsonMulti100000Pretty);
        }


        // Jill //
        [Benchmark]
        public List<Mock0>? JilJsonDeserializeSimpleSingleCompact()
        {
            return Jil.JSON.Deserialize<List<Mock0>>(dataSimpleJsonCompact);
        }

        [Benchmark]
        public List<Mock0>? JilJsonDeserializeSimpleSinglePretty()
        {
            return Jil.JSON.Deserialize<List<Mock0>>(dataSimpleJsonPretty);
        }

        [Benchmark]
        public List<Mock0>? JilJsonDeserializeSimpleMulti1000Compact()
        {
            return Jil.JSON.Deserialize<List<Mock0>>(dataJsonMulti1000Compact);
        }

        [Benchmark]
        public List<Mock0>? JilJsonDeserializeSimpleMulti1000Pretty()
        {
            return Jil.JSON.Deserialize<List<Mock0>>(dataJsonMulti1000Pretty);
        }

        [Benchmark]
        public List<Mock0>? JilJsonDeserializeSimpleMulti10000Compact()
        {
            return Jil.JSON.Deserialize<List<Mock0>>(dataJsonMulti10000Compact);
        }

        [Benchmark]
        public List<Mock0>? JilJsonDeserializeSimpleMulti10000Pretty()
        {
            return Jil.JSON.Deserialize<List<Mock0>>(dataJsonMulti10000Pretty);
        }

        [Benchmark]
        public List<Mock0>? JilJsonDeserializeSimpleMulti100000Compact()
        {
            return Jil.JSON.Deserialize<List<Mock0>>(dataJsonMulti100000Compact);
        }

        [Benchmark]
        public List<Mock0>? JilJsonDeserializeSimpleMulti100000Pretty()
        {
            return Jil.JSON.Deserialize<List<Mock0>>(dataJsonMulti100000Pretty);
        }


        // NetJSON //
        [Benchmark]
        public List<Mock0>? NetJSONDeserializeSimpleSingleCompact()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock0>>(dataSimpleJsonCompact);
        }

        [Benchmark]
        public List<Mock0>? NetJSONDeserializeSimpleSinglePretty()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock0>>(dataSimpleJsonPretty);
        }

        [Benchmark]
        public List<Mock0>? NetJSONDeserializeSimpleMulti1000Compact()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock0>>(dataJsonMulti1000Compact);
        }

        [Benchmark]
        public List<Mock0>? NetJSONDeserializeSimpleMulti1000Pretty()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock0>>(dataJsonMulti1000Pretty);
        }

        [Benchmark]
        public List<Mock0>? NetJSONDeserializeSimpleMulti10000Compact()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock0>>(dataJsonMulti10000Compact);
        }

        [Benchmark]
        public List<Mock0>? NetJSONDeserializeSimpleMulti10000Pretty()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock0>>(dataJsonMulti10000Pretty);
        }

        [Benchmark]
        public List<Mock0>? NetJSONDeserializeSimpleMulti100000Compact()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock0>>(dataJsonMulti100000Compact);
        }

        [Benchmark]
        public List<Mock0>? NetJSONDeserializeSimpleMulti100000Pretty()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock0>>(dataJsonMulti100000Pretty);
        }


        // FastJson //
        [Benchmark]
        public List<Mock0>? FastJsonDeserializeSimpleSingleCompact()
        {
            return fastJSON.JSON.ToObject<List<Mock0>>(dataSimpleJsonCompact);
        }

        [Benchmark]
        public List<Mock0>? FastJsonDeserializeSinglePretty()
        {
            return fastJSON.JSON.ToObject<List<Mock0>>(dataSimpleJsonPretty);
        }

        [Benchmark]
        public List<Mock0>? FastJsonDeserializeSimpleMulti1000Compact()
        {
            return fastJSON.JSON.ToObject<List<Mock0>>(dataJsonMulti1000Compact);
        }

        [Benchmark]
        public List<Mock0>? FastJsonDeserializeSimpleMulti1000Pretty()
        {
            return fastJSON.JSON.ToObject<List<Mock0>>(dataJsonMulti1000Pretty);
        }

        [Benchmark]
        public List<Mock0>? FastJsonDeserializeSimpleMulti10000Compact()
        {
            return fastJSON.JSON.ToObject<List<Mock0>>(dataJsonMulti10000Compact);
        }

        [Benchmark]
        public List<Mock0>? FastJsonDeserializeSimpleMulti10000Pretty()
        {
            return fastJSON.JSON.ToObject<List<Mock0>>(dataJsonMulti10000Pretty);
        }

        [Benchmark]
        public List<Mock0>? FastJsonDeserializeSimpleMulti100000Compact()
        {
            return fastJSON.JSON.ToObject<List<Mock0>>(dataJsonMulti100000Compact);
        }

        [Benchmark]
        public List<Mock0>? FastJsonDeserializeSimpleMulti100000Pretty()
        {
            return fastJSON.JSON.ToObject<List<Mock0>>(dataJsonMulti100000Pretty);
        }
    }
}