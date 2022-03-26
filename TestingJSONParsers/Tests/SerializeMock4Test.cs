﻿using BenchmarkDotNet.Attributes;
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
    [SimpleJob(launchCount: 1, warmupCount: 20, targetCount: 20)]

    public class SerializeMock4Test
    {
        private readonly List<Mock4>? dataSingleCompact;
        private readonly List<Mock4>? dataSinglePretty;
        private readonly List<Mock4>? dataMulti1000Compact;
        private readonly List<Mock4>? dataMulti1000Pretty;
        private readonly List<Mock4>? dataMulti10000Compact;
        private readonly List<Mock4>? dataMulti10000Pretty;
        private readonly List<Mock4>? dataMulti100000Compact;
        private readonly List<Mock4>? dataMulti100000Pretty;

        public SerializeMock4Test()
        {
            this.dataSingleCompact = Tools.CreateMockObjectsX<Mock4>(1, 'C');
            this.dataSinglePretty = Tools.CreateMockObjectsX<Mock4>(1, 'P');
            this.dataMulti1000Compact = Tools.CreateMockObjectsX<Mock4>(1000, 'C');
            this.dataMulti1000Pretty = Tools.CreateMockObjectsX<Mock4>(1000, 'P');
            this.dataMulti10000Compact = Tools.CreateMockObjectsX<Mock4>(10000, 'C');
            this.dataMulti10000Pretty = Tools.CreateMockObjectsX<Mock4>(10000, 'P');
            this.dataMulti100000Compact = Tools.CreateMockObjectsX<Mock4>(100000, 'C');
            this.dataMulti100000Pretty = Tools.CreateMockObjectsX<Mock4>(100000, 'P');
            //this.dataComplexMockJson = System.Text.Json.JsonSerializer.Serialize(dataComplexMock);
            //var array = Encoding.UTF8.GetBytes(dataSimpleJson);
        }


        // Serializing //
        // System.Text.Json //
        [Benchmark]
        public string SystemTextJsonSerializeSingleCompact()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataSingleCompact);
        }

        [Benchmark]
        public string SystemTextJsonSerializeSingleSinglePretty()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataSinglePretty);
        }

        [Benchmark]
        public string SystemTextJsonSerializeMulti1000Compact()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti1000Compact);
        }

        [Benchmark]
        public string SystemTextJsonSerializeMulti1000Pretty()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti1000Pretty);
        }

        [Benchmark]
        public string SystemTextJsonSerializeMulti10000Compact()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti10000Compact);
        }

        [Benchmark]
        public string SystemTextJsonSerializeMulti10000Pretty()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti10000Pretty);
        }

        [Benchmark]
        public string SystemTextJsonSerializeMulti100000Compact()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti100000Compact);
        }

        [Benchmark]
        public string SystemTextJsonSerializeMulti100000Pretty()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti100000Pretty);
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataSinglePretty);
        }

        [Benchmark]
        public string NewtonsoftJsoneSerializeMulti1000Compact()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataMulti1000Compact);
        }

        [Benchmark]
        public string NewtonsoftJsonComplexSerializeMulti1000Pretty()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataMulti1000Pretty);
        }

        [Benchmark]
        public string NewtonsoftJsoneSerializeMulti10000Compact()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataMulti10000Compact);
        }

        [Benchmark]
        public string NewtonsoftJsonComplexSerializeMulti10000Pretty()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataMulti10000Pretty);
        }

        [Benchmark]
        public string NewtonsoftJsoneSerializeMulti100000Compact()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataMulti100000Compact);
        }

        [Benchmark]
        public string NewtonsoftJsonComplexSerializeMulti100000Pretty()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dataMulti100000Pretty);
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
            return Jil.JSON.Serialize(dataSinglePretty);
        }

        [Benchmark]
        public string JilJsonSerializeMulti1000Compact()
        {
            return Jil.JSON.Serialize(dataMulti1000Compact);
        }

        [Benchmark]
        public string JilJsonSerializeMulti1000Pretty()
        {
            return Jil.JSON.Serialize(dataMulti1000Pretty);
        }

        [Benchmark]
        public string JilJsonSerializeMulti10000Compact()
        {
            return Jil.JSON.Serialize(dataMulti10000Compact);
        }

        [Benchmark]
        public string JilJsonSerializeMulti10000Pretty()
        {
            return Jil.JSON.Serialize(dataMulti10000Pretty);
        }

        [Benchmark]
        public string JilJsonSerializeMulti100000Compact()
        {
            return Jil.JSON.Serialize(dataMulti100000Compact);
        }

        [Benchmark]
        public string JilJsonSerializeMulti100000Pretty()
        {
            return Jil.JSON.Serialize(dataMulti100000Pretty);
        }


        // FastJson //
        [Benchmark]
        public string FastJsonSerializeSingleCompact()
        {
            return fastJSON.JSON.ToJSON(dataSingleCompact);
        }

        [Benchmark]
        public string FastJsonComplexSerializeSinglePretty()
        {
            return fastJSON.JSON.ToJSON(dataSinglePretty);
        }

        public string FastJsonSerializeMulti1000Compact()
        {
            return fastJSON.JSON.ToJSON(dataMulti1000Compact);
        }

        [Benchmark]
        public string FastJsonComplexSerializeMulti1000Pretty()
        {
            return fastJSON.JSON.ToJSON(dataMulti1000Pretty);
        }

        public string FastJsonSerializeMulti10000Compact()
        {
            return fastJSON.JSON.ToJSON(dataMulti10000Compact);
        }

        [Benchmark]
        public string FastJsonComplexSerializeMulti10000Pretty()
        {
            return fastJSON.JSON.ToJSON(dataMulti10000Pretty);
        }

        public string FastJsonSerializeMulti100000Compact()
        {
            return fastJSON.JSON.ToJSON(dataMulti100000Compact);
        }

        [Benchmark]
        public string FastJsonComplexSerializeMulti100000Pretty()
        {
            return fastJSON.JSON.ToJSON(dataMulti100000Pretty);
        }


        // SpanJson //
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
            return SpanJson.JsonSerializer.Generic.Utf8.Serialize(dataSinglePretty);
        }

        [Benchmark]
        public string SpanJsonSerializeUtf16SinglePretty()
        {
            return SpanJson.JsonSerializer.Generic.Utf16.Serialize(dataSinglePretty);
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
            return SpanJson.JsonSerializer.Generic.Utf8.Serialize(dataMulti1000Pretty);
        }

        [Benchmark]
        public string SpanJsonSerializeUtf16Multi1000Pretty()
        {
            return SpanJson.JsonSerializer.Generic.Utf16.Serialize(dataMulti1000Pretty);
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
            return SpanJson.JsonSerializer.Generic.Utf8.Serialize(dataMulti10000Pretty);
        }

        [Benchmark]
        public string SpanJsonSerializeUtf16Multi10000Pretty()
        {
            return SpanJson.JsonSerializer.Generic.Utf16.Serialize(dataMulti10000Pretty);
        }
    }
}