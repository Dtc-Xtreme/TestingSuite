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

namespace TestingSuite.Tests
{
    [MemoryDiagnoser]
    [SimpleJob(launchCount: 1, warmupCount: 5, targetCount: 5)]
    //[SimpleJob(launchCount: 10, warmupCount: 100, targetCount: 50)]

    public class SerializeMock1Test
    {
        private readonly List<Mock1>? dataSingleCompact;
        //private readonly List<Mock1>? dataSinglePretty;
        private readonly List<Mock1>? dataMulti1000Compact;
        //private readonly List<Mock1>? dataMulti1000Pretty;
        private readonly List<Mock1>? dataMulti10000Compact;
        //private readonly List<Mock1>? dataMulti10000Pretty;
        private readonly List<Mock1>? dataMulti100000Compact;
        //private readonly List<Mock1>? dataMulti100000Pretty;
        private readonly JsonSerializerOptions jsonSerializerOptions;
        private readonly Options JillOption;

        public SerializeMock1Test()
        {
            this.dataSingleCompact = Tools.CreateMockObjectsX<Mock1>(1, 'C');
            //this.dataSinglePretty = Tools.CreateMockObjectsX<Mock1>(1, 'P');
            this.dataMulti1000Compact = Tools.CreateMockObjectsX<Mock1>(1000, 'C');
            //this.dataMulti1000Pretty = Tools.CreateMockObjectsX<Mock1>(1000, 'P');
            this.dataMulti10000Compact = Tools.CreateMockObjectsX<Mock1>(10000, 'C');
            //this.dataMulti10000Pretty = Tools.CreateMockObjectsX<Mock1>(10000, 'P');
            this.dataMulti100000Compact = Tools.CreateMockObjectsX<Mock1>(100000, 'C');
            //this.dataMulti100000Pretty = Tools.CreateMockObjectsX<Mock1>(100000, 'P');
            this.jsonSerializerOptions = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            JillOption = new Options(prettyPrint: true);
        }


        // Serializing //
        // System.Text.Json //
        [Benchmark]
        public string SystemTextJsonSerializeSingleCompactWithContext()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataSingleCompact, Mock1JsonSerializerContext.Default.ListMock1);
        }

        [Benchmark]
        public string SystemTextJsonSerializeSingleCompact()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataSingleCompact);
        }

        [Benchmark]
        public string SystemTextJsonSerializeSingleSinglePretty()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataSingleCompact, jsonSerializerOptions);
        }

        [Benchmark]
        public string SystemTextJsonSerializeMulti1000Compact()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti1000Compact);
        }

        [Benchmark]
        public string SystemTextJsonSerializeMulti1000Pretty()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti1000Compact, jsonSerializerOptions);
        }

        [Benchmark]
        public string SystemTextJsonSerializeMulti10000CompactWithContext()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti10000Compact, Mock1JsonSerializerContext.Default.ListMock1);
        }

        [Benchmark]
        public string SystemTextJsonSerializeMulti10000Compact()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti10000Compact);
        }

        [Benchmark]
        public string SystemTextJsonSerializeMulti10000Pretty()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti10000Compact, jsonSerializerOptions);
        }

        [Benchmark]
        public string SystemTextJsonSerializeMulti100000Compact()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti100000Compact);
        }

        [Benchmark]
        public string SystemTextJsonSerializeMulti100000Pretty()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti100000Compact, jsonSerializerOptions);
        }

        // NewtonsoftJson //
        [Benchmark]
        public string NewtonsoftJsoneSerializeSingleCompact()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataSingleCompact);
        }

        [Benchmark]
        public string NewtonsoftJsonComplexSerializeSinglePretty()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataSingleCompact, Formatting.Indented);
        }

        [Benchmark]
        public string NewtonsoftJsoneSerializeMulti1000Compact()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataMulti1000Compact);
        }

        [Benchmark]
        public string NewtonsoftJsonComplexSerializeMulti1000Pretty()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataMulti1000Compact, Formatting.Indented);
        }

        [Benchmark]
        public string NewtonsoftJsoneSerializeMulti10000Compact()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataMulti10000Compact);
        }

        [Benchmark]
        public string NewtonsoftJsonComplexSerializeMulti10000Pretty()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataMulti10000Compact, Formatting.Indented);
        }

        [Benchmark]
        public string NewtonsoftJsoneSerializeMulti100000Compact()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataMulti100000Compact);
        }

        [Benchmark]
        public string NewtonsoftJsonComplexSerializeMulti100000Pretty()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataMulti100000Compact, Formatting.Indented);
        }


        // Jil //
        [Benchmark]
        public string JilJsonSerializeSingleCompact()
        {
            return Jil.JSON.Serialize(dataSingleCompact);
        }

        [Benchmark]
        public string JilJsonSerializeSinglePretty()
        {
            return Jil.JSON.Serialize(dataSingleCompact, JillOption);
        }

        [Benchmark]
        public string JilJsonSerializeMulti1000Compact()
        {
            return Jil.JSON.Serialize(dataMulti1000Compact);
        }

        [Benchmark]
        public string JilJsonSerializeMulti1000Pretty()
        {
            return Jil.JSON.Serialize(dataMulti1000Compact, JillOption);
        }

        [Benchmark]
        public string JilJsonSerializeMulti10000Compact()
        {
            return Jil.JSON.Serialize(dataMulti10000Compact);
        }

        [Benchmark]
        public string JilJsonSerializeMulti10000Pretty()
        {
            return Jil.JSON.Serialize(dataMulti10000Compact, JillOption);
        }

        [Benchmark]
        public string JilJsonSerializeMulti100000Compact()
        {
            return Jil.JSON.Serialize(dataMulti100000Compact);
        }

        [Benchmark]
        public string JilJsonSerializeMulti100000Pretty()
        {
            return Jil.JSON.Serialize(dataMulti100000Compact, JillOption);
        }


        // FastJson //
        [Benchmark]
        public string FastJsonSerializeSingleCompact()
        {
            return fastJSON.JSON.ToJSON(dataSingleCompact);
        }

        [Benchmark]
        public string FastJsonSerializeSinglePretty()
        {
            return fastJSON.JSON.ToNiceJSON(dataSingleCompact);
        }

        [Benchmark]
        public string FastJsonSerializeMulti1000Compact()
        {
            return fastJSON.JSON.ToJSON(dataMulti1000Compact);
        }

        [Benchmark]
        public string FastJsonSerializeMulti1000Pretty()
        {
            return fastJSON.JSON.ToNiceJSON(dataMulti1000Compact);
        }

        [Benchmark]
        public string FastJsonSerializeMulti10000Compact()
        {
            return fastJSON.JSON.ToJSON(dataMulti10000Compact);
        }

        [Benchmark]
        public string FastJsonSerializeMulti10000Pretty()
        {
            return fastJSON.JSON.ToNiceJSON(dataMulti10000Compact);
        }

        [Benchmark]
        public string FastJsonSerializeMulti100000Compact()
        {
            return fastJSON.JSON.ToJSON(dataMulti100000Compact);
        }

        [Benchmark]
        public string FastJsonSerializeMulti100000Pretty()
        {
            return fastJSON.JSON.ToNiceJSON(dataMulti100000Compact);
        }


        // SpanJson // pretty printer en minified van maken en apparte test voor utf8 vs utf16
        [Benchmark]
        public byte[] SpanJsonSerializeUtf8SingleCompact()
        {
            return SpanJson.JsonSerializer.Generic.Utf8.Serialize(dataSingleCompact);
        }

        [Benchmark]
        public string SpanJsonSerializeUtf16SingleCompact()
        {
            return SpanJson.JsonSerializer.Generic.Utf16.Serialize(dataSingleCompact);
        }

        [Benchmark]
        public byte[] SpanJsonSerializeUtf8SinglePretty()
        {
            return SpanJson.JsonSerializer.Generic.Utf8.Serialize(dataSingleCompact);
        }

        [Benchmark]
        public string SpanJsonSerializeUtf16SinglePretty()
        {
            return SpanJson.JsonSerializer.Generic.Utf16.Serialize(dataSingleCompact);
        }

        [Benchmark]
        public byte[] SpanJsonSerializeUtf8Multi1000Compact()
        {
            return SpanJson.JsonSerializer.Generic.Utf8.Serialize(dataMulti1000Compact);
        }

        [Benchmark]
        public string SpanJsonSerializeUtf16Multi1000Compact()
        {
            return SpanJson.JsonSerializer.Generic.Utf16.Serialize(dataMulti1000Compact);
        }

        [Benchmark]
        public byte[] SpanJsonSerializeUtf8Multi1000Pretty()
        {
            return SpanJson.JsonSerializer.Generic.Utf8.Serialize(dataMulti1000Compact);
        }

        [Benchmark]
        public string SpanJsonSerializeUtf16Multi1000Pretty()
        {
            return SpanJson.JsonSerializer.Generic.Utf16.Serialize(dataMulti1000Compact);
        }

        [Benchmark]
        public byte[] SpanJsonSerializeUtf8Multi10000Compact()
        {
            return SpanJson.JsonSerializer.Generic.Utf8.Serialize(dataMulti10000Compact);
        }

        [Benchmark]
        public string SpanJsonSerializeUtf16Multi10000Compact()
        {
            return SpanJson.JsonSerializer.Generic.Utf16.Serialize(dataMulti10000Compact);
        }

        [Benchmark]
        public byte[] SpanJsonSerializeUtf8Multi10000Pretty()
        {
            return SpanJson.JsonSerializer.Generic.Utf8.Serialize(dataMulti10000Compact);
        }

        [Benchmark]
        public string SpanJsonSerializeUtf16Multi10000Pretty()
        {
            return SpanJson.JsonSerializer.Generic.Utf16.Serialize(dataMulti10000Compact);
        }
    }
}