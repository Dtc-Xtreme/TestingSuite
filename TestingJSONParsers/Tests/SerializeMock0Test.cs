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
using NetJSON;
using SpanJson.Resolvers;

namespace TestingSuite.Tests
{
    [MemoryDiagnoser]
    [SimpleJob(launchCount: 1, warmupCount: 5, targetCount: 5)]
    //[SimpleJob(launchCount: 10, warmupCount: 100, targetCount: 50)]

    public class SerializeMock0Test
    {
        private readonly List<Mock0>? dataSingleCompact;
        private readonly List<Mock0>? dataMulti1000Compact;
        private readonly List<Mock0>? dataMulti10000Compact;
        private readonly List<Mock0>? dataMulti100000Compact;
        private readonly JsonSerializerOptions jsonSerializerOptions;
        private readonly Options JillOption;

        public SerializeMock0Test()
        {
            this.dataSingleCompact = Tools.CreateMockObjectsX<Mock0>(1, 'C', true);
            this.dataMulti1000Compact = Tools.CreateMockObjectsX<Mock0>(1000, 'C', true);
            this.dataMulti10000Compact = Tools.CreateMockObjectsX<Mock0>(10000, 'C', true);
            this.dataMulti100000Compact = Tools.CreateMockObjectsX<Mock0>(100000, 'C', true);
            this.jsonSerializerOptions = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            JillOption = new Options(prettyPrint: true);
        }


        // Serializing //
        // System.Text.Json //
        [Benchmark]
        public string SystemTextJsonSerializeSimpleSingleCompact()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataSingleCompact);
        }

        [Benchmark]
        public string SystemTextJsonSerializeSimpleSingleSinglePretty()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataSingleCompact, jsonSerializerOptions);
        }

        [Benchmark]
        public string SystemTextJsonSerializeSimpleMulti1000Compact()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti1000Compact);
        }

        [Benchmark]
        public string SystemTextJsonSerializeSimpleMulti1000Pretty()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti1000Compact, jsonSerializerOptions);
        }

        [Benchmark]
        public string SystemTextJsonSerializeSimpleMulti10000Compact()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti10000Compact);
        }

        [Benchmark]
        public string SystemTextJsonSerializeSimpleMulti10000Pretty()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti10000Compact, jsonSerializerOptions);
        }

        [Benchmark]
        public string SystemTextJsonSerializeSimpleMulti100000Compact()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti100000Compact);
        }

        [Benchmark]
        public string SystemTextJsonSerializeSimpleMulti100000Pretty()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti100000Compact, jsonSerializerOptions);
        }

        // NewtonsoftJson //
        [Benchmark]
        public string NewtonsoftJsoneSerializeSimpleSingleCompact()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataSingleCompact);
        }

        [Benchmark]
        public string NewtonsoftJsonComplexSerializeSimpleSinglePretty()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataSingleCompact, Formatting.Indented);
        }

        [Benchmark]
        public string NewtonsoftJsoneSerializeSimpleMulti1000Compact()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataMulti1000Compact);
        }

        [Benchmark]
        public string NewtonsoftJsonComplexSerializeSimpleMulti1000Pretty()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataMulti1000Compact, Formatting.Indented);
        }

        [Benchmark]
        public string NewtonsoftJsoneSerializeSimpleMulti10000Compact()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataMulti10000Compact);
        }

        [Benchmark]
        public string NewtonsoftJsonComplexSerializeSimpleMulti10000Pretty()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataMulti10000Compact, Formatting.Indented);
        }

        [Benchmark]
        public string NewtonsoftJsoneSerializeSimpleMulti100000Compact()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataMulti100000Compact);
        }

        [Benchmark]
        public string NewtonsoftJsonComplexSerializeSimpleMulti100000Pretty()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataMulti100000Compact, Formatting.Indented);
        }


        // Jil //
        [Benchmark]
        public string JilJsonSerializeSimpleSingleCompact()
        {
            return Jil.JSON.Serialize(dataSingleCompact);
        }

        [Benchmark]
        public string JilJsonSerializeSimpleSinglePretty()
        {
            return Jil.JSON.Serialize(dataSingleCompact, JillOption);
        }

        [Benchmark]
        public string JilJsonSerializeSimpleMulti1000Compact()
        {
            return Jil.JSON.Serialize(dataMulti1000Compact);
        }

        [Benchmark]
        public string JilJsonSerializeSimpleMulti1000Pretty()
        {
            return Jil.JSON.Serialize(dataMulti1000Compact, JillOption);
        }

        [Benchmark]
        public string JilJsonSerializeSimpleMulti10000Compact()
        {
            return Jil.JSON.Serialize(dataMulti10000Compact);
        }

        [Benchmark]
        public string JilJsonSerializeSimpleMulti10000Pretty()
        {
            return Jil.JSON.Serialize(dataMulti10000Compact, JillOption);
        }

        [Benchmark]
        public string JilJsonSerializeSimpleMulti100000Compact()
        {
            return Jil.JSON.Serialize(dataMulti100000Compact);
        }

        [Benchmark]
        public string JilJsonSerializeSimpleMulti100000Pretty()
        {
            return Jil.JSON.Serialize(dataMulti100000Compact, JillOption);
        }


        // NETJson //
        [Benchmark]
        public string NetJSONSerializeSimpleSingle()
        {
            return NetJSON.NetJSON.Serialize(dataSingleCompact);
        }

        [Benchmark]
        public string NetJSONSerializeSimpleMulti1000()
        {
            return NetJSON.NetJSON.Serialize(dataMulti1000Compact);
        }

        [Benchmark]
        public string NetJSONSerializeSimpleMulti10000()
        {
            return NetJSON.NetJSON.Serialize(dataMulti10000Compact);
        }

        [Benchmark]
        public string NetJSONSerializeSimpleMulti100000()
        {
            return NetJSON.NetJSON.Serialize(dataMulti100000Compact);
        }


        // FastJson //
        [Benchmark]
        public string FastJsonSerializeSimpleSingleCompact()
        {
            return fastJSON.JSON.ToJSON(dataSingleCompact);
        }

        [Benchmark]
        public string FastJsonSerializeSimpleSinglePretty()
        {
            return fastJSON.JSON.ToNiceJSON(dataSingleCompact);
        }

        [Benchmark]
        public string FastJsonSerializeSimpleMulti1000Compact()
        {
            return fastJSON.JSON.ToJSON(dataMulti1000Compact);
        }

        [Benchmark]
        public string FastJsonSerializeSimpleMulti1000Pretty()
        {
            return fastJSON.JSON.ToNiceJSON(dataMulti1000Compact);
        }

        [Benchmark]
        public string FastJsonSerializeSimpleMulti10000Compact()
        {
            return fastJSON.JSON.ToJSON(dataMulti10000Compact);
        }

        [Benchmark]
        public string FastJsonSerializeSimpleMulti10000Pretty()
        {
            return fastJSON.JSON.ToNiceJSON(dataMulti10000Compact);
        }

        [Benchmark]
        public string FastJsonSerializeSimpleMulti100000Compact()
        {
            return fastJSON.JSON.ToJSON(dataMulti100000Compact);
        }

        [Benchmark]
        public string FastJsonSerializeSimpleMulti100000Pretty()
        {
            return fastJSON.JSON.ToNiceJSON(dataMulti100000Compact);
        }
    }
}