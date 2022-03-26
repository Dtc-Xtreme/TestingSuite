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
    //[SimpleJob(launchCount: 10, warmupCount: 100, targetCount: 50)]
    [SimpleJob(launchCount: 1, warmupCount: 10, targetCount: 5)]

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
        public List<Mock1>? SystemTextJsonDeserializeSimpleCompact()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock1>>(dataSimpleJsonCompact);
        }

        [Benchmark]
        public List<Mock1>? SystemTextJsonDeserializeSimplePretty()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock1>>(dataSimpleJsonPretty);
        }

        [Benchmark]
        public List<Mock1>? SystemTextJsonDeserializeMulti1000Compact()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock1>>(dataJsonMulti1000Compact);
        }

        [Benchmark]
        public List<Mock1>? SystemTextJsonDeserializeMulti1000Pretty()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock1>>(dataJsonMulti1000Pretty);
        }

        [Benchmark]
        public List<Mock1>? SystemTextJsonDeserializeMulti10000Compact()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock1>>(dataJsonMulti10000Compact);
        }

        [Benchmark]
        public List<Mock1>? SystemTextJsonDeserializeMulti10000Pretty()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock1>>(dataJsonMulti10000Pretty);
        }

        [Benchmark]
        public List<Mock1>? SystemTextJsonDeserializeMulti100000Compact()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock1>>(dataJsonMulti100000Compact);
        }

        [Benchmark]
        public List<Mock1>? SystemTextJsonDeserializeMulti100000Pretty()
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<Mock1>>(dataJsonMulti100000Pretty);
        }


        // Newtonsoft //
        [Benchmark]
        public List<Mock1>? NewtonsoftJsonDeserializeSingleCompact()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock1>>(dataSimpleJsonCompact);
        }

        [Benchmark]
        public List<Mock1>? NewtonsoftJsonDeserializeSinlePretty()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock1>>(dataSimpleJsonPretty);
        }

        [Benchmark]
        public List<Mock1>? NewtonsoftJsonDeserializeMulti1000Compact()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock1>>(dataJsonMulti1000Compact);
        }

        [Benchmark]
        public List<Mock1>? NewtonsoftJsonDeserializeMulti1000Pretty()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock1>>(dataJsonMulti1000Pretty);
        }

        [Benchmark]
        public List<Mock1>? NewtonsoftJsonDeserializeMulti10000Compact()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock1>>(dataJsonMulti10000Compact);
        }

        [Benchmark]
        public List<Mock1>? NewtonsoftJsonDeserializeMulti10000Pretty()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock1>>(dataJsonMulti10000Pretty);
        }

        [Benchmark]
        public List<Mock1>? NewtonsoftJsonDeserializeMulti100000Compact()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock1>>(dataJsonMulti100000Compact);
        }

        [Benchmark]
        public List<Mock1>? NewtonsoftJsonDeserializeMulti100000Pretty()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Mock1>>(dataJsonMulti100000Pretty);
        }


        // Jill //
        [Benchmark]
        public List<Mock1>? JilJsonDeserializeSingleCompact()
        {
            return Jil.JSON.Deserialize<List<Mock1>>(dataSimpleJsonCompact);
        }

        [Benchmark]
        public List<Mock1>? JilJsonDeserializeSinglePretty()
        {
            return Jil.JSON.Deserialize<List<Mock1>>(dataSimpleJsonPretty);
        }

        [Benchmark]
        public List<Mock1>? JilJsonDeserializeMulti1000Compact()
        {
            return Jil.JSON.Deserialize<List<Mock1>>(dataJsonMulti1000Compact);
        }

        [Benchmark]
        public List<Mock1>? JilJsonDeserializeMulti1000Pretty()
        {
            return Jil.JSON.Deserialize<List<Mock1>>(dataJsonMulti1000Pretty);
        }

        [Benchmark]
        public List<Mock1>? JilJsonDeserializeMulti10000Compact()
        {
            return Jil.JSON.Deserialize<List<Mock1>>(dataJsonMulti10000Compact);
        }

        [Benchmark]
        public List<Mock1>? JilJsonDeserializeMulti10000Pretty()
        {
            return Jil.JSON.Deserialize<List<Mock1>>(dataJsonMulti10000Pretty);
        }

        [Benchmark]
        public List<Mock1>? JilJsonDeserializeMulti100000Compact()
        {
            return Jil.JSON.Deserialize<List<Mock1>>(dataJsonMulti100000Compact);
        }

        [Benchmark]
        public List<Mock1>? JilJsonDeserializeMulti100000Pretty()
        {
            return Jil.JSON.Deserialize<List<Mock1>>(dataJsonMulti100000Pretty);
        }


        // Deserializing Files worden opvoorhand ingelezen om de vershillen in laad tijden te vermijden //
        // NetJSON //
        [Benchmark]
        public List<Mock1>? NetJSONDeserializeSimpleCompact()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock1>>(dataSimpleJsonCompact);
        }

        [Benchmark]
        public List<Mock1>? NetJSONDeserializeSimplePretty()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock1>>(dataSimpleJsonPretty);
        }

        [Benchmark]
        public List<Mock1>? NetJSONDeserializeMulti1000Compact()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock1>>(dataJsonMulti1000Compact);
        }

        [Benchmark]
        public List<Mock1>? NetJSONDeserializeMulti1000Pretty()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock1>>(dataJsonMulti1000Pretty);
        }

        [Benchmark]
        public List<Mock1>? NetJSONDeserializeMulti10000Compact()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock1>>(dataJsonMulti10000Compact);
        }

        [Benchmark]
        public List<Mock1>? NetJSONDeserializeMulti10000Pretty()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock1>>(dataJsonMulti10000Pretty);
        }

        [Benchmark]
        public List<Mock1>? NetJSONDeserializeMulti100000Compact()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock1>>(dataJsonMulti100000Compact);
        }

        [Benchmark]
        public List<Mock1>? NetJSONDeserializeMulti100000Pretty()
        {
            return NetJSON.NetJSON.Deserialize<List<Mock1>>(dataJsonMulti100000Pretty);
        }

        //// FastJson //
        //[Benchmark]
        //public List<Mock1>? FastJsonDeserializeSingleCompact()
        //{
        //    return fastJSON.JSON.ToObject<List<Mock1>>(dataSimpleJsonCompact);
        //}

        //[Benchmark]
        //public List<Mock1>? FastJsonDeserializeSinglePretty()
        //{
        //    return fastJSON.JSON.ToObject<List<Mock1>>(dataSimpleJsonPretty);
        //}

        //[Benchmark]
        //public List<Mock1>? FastJsonDeserializeMulti1000Compact()
        //{
        //    return fastJSON.JSON.ToObject<List<Mock1>>(dataJsonMulti1000Compact);
        //}

        //[Benchmark]
        //public List<Mock1>? FastJsonDeserializeMulti1000Pretty()
        //{
        //    return fastJSON.JSON.ToObject<List<Mock1>>(dataJsonMulti1000Pretty);
        //}

        //[Benchmark]
        //public List<Mock1>? FastJsonDeserializeMulti10000Compact()
        //{
        //    return fastJSON.JSON.ToObject<List<Mock1>>(dataJsonMulti10000Compact);
        //}

        //[Benchmark]
        //public List<Mock1>? FastJsonDeserializeMulti10000Pretty()
        //{
        //    return fastJSON.JSON.ToObject<List<Mock1>>(dataJsonMulti10000Pretty);
        //}

        //[Benchmark]
        //public List<Mock1>? FastJsonDeserializeMulti100000Compact()
        //{
        //    return fastJSON.JSON.ToObject<List<Mock1>>(dataJsonMulti100000Compact);
        //}

        //[Benchmark]
        //public List<Mock1>? FastJsonDeserializeMulti100000Pretty()
        //{
        //    return fastJSON.JSON.ToObject<List<Mock1>>(dataJsonMulti100000Pretty);
        //}


        // SpanJson //
        //[Benchmark]
        //public List<Mock1>? SpanJsonDeserializeUtf8SingleCompact()
        //{
        //    var array = Encoding.UTF8.GetBytes(dataSimpleJsonCompact);
        //    var arraySpan = new Span<byte>(array);
        //    return SpanJson.JsonSerializer.Generic.Utf8.Deserialize<List<Mock1>>(arraySpan);
        //}

        //[Benchmark]
        //public List<Mock1>? SpanJsonDeserializeUtf16SingleCompact()
        //{
        //    return SpanJson.JsonSerializer.Generic.Utf16.Deserialize<List<Mock1>>(dataSimpleJsonCompact);

        //}

        //[Benchmark]
        //public List<Mock1>? SpanJsonDeserializeUtf8SinglePretty()
        //{
        //    var array = Encoding.UTF8.GetBytes(dataSimpleJsonPretty);
        //    var arraySpan = new Span<byte>(array);
        //    return SpanJson.JsonSerializer.Generic.Utf8.Deserialize<List<Mock1>>(arraySpan);
        //}

        //[Benchmark]
        //public List<Mock1>? SpanJsonDeserializeUtf16SinglePretty()
        //{
        //    return SpanJson.JsonSerializer.Generic.Utf16.Deserialize<List<Mock1>>(dataSimpleJsonPretty);
        //}

        //[Benchmark]
        //public List<Mock1>? SpanJsonDeserializeUtf8Multi1000Compact()
        //{
        //    var array = Encoding.UTF8.GetBytes(dataJsonMulti1000Compact);
        //    var arraySpan = new Span<byte>(array);
        //    return SpanJson.JsonSerializer.Generic.Utf8.Deserialize<List<Mock1>>(arraySpan);
        //}

        //[Benchmark]
        //public List<Mock1>? SpanJsonDeserializeUtf16Multi1000Compact()
        //{
        //    return SpanJson.JsonSerializer.Generic.Utf16.Deserialize<List<Mock1>>(dataJsonMulti1000Compact);
        //}

        //[Benchmark]
        //public List<Mock1>? SpanJsonDeserializeUtf8Multi1000Pretty()
        //{
        //    var array = Encoding.UTF8.GetBytes(dataJsonMulti1000Pretty);
        //    var arraySpan = new Span<byte>(array);
        //    return SpanJson.JsonSerializer.Generic.Utf8.Deserialize<List<Mock1>>(arraySpan);
        //}

        //[Benchmark]
        //public List<Mock1>? SpanJsonDeserializeUtf16Multi1000Pretty()
        //{
        //    return SpanJson.JsonSerializer.Generic.Utf16.Deserialize<List<Mock1>>(dataJsonMulti1000Pretty);

        //}

        //[Benchmark]
        //public List<Mock1>? SpanJsonDeserializeUtf8Multi10000Compact()
        //{
        //    var array = Encoding.UTF8.GetBytes(dataJsonMulti10000Compact);
        //    var arraySpan = new Span<byte>(array);
        //    return SpanJson.JsonSerializer.Generic.Utf8.Deserialize<List<Mock1>>(arraySpan);
        //}

        //[Benchmark]
        //public List<Mock1>? SpanJsonDeserializeUtf16Multi10000Compact()
        //{
        //    return SpanJson.JsonSerializer.Generic.Utf16.Deserialize<List<Mock1>>(dataJsonMulti10000Compact);
        //}

        //[Benchmark]
        //public List<Mock1>? SpanJsonDeserializeUtf8Multi10000Pretty()
        //{
        //    var array = Encoding.UTF8.GetBytes(dataJsonMulti10000Pretty);
        //    var arraySpan = new Span<byte>(array);
        //    return SpanJson.JsonSerializer.Generic.Utf8.Deserialize<List<Mock1>>(arraySpan);
        //}

        //[Benchmark]
        //public List<Mock1>? SpanJsonDeserializeUtf16Multi10000Pretty()
        //{
        //    return SpanJson.JsonSerializer.Generic.Utf16.Deserialize<List<Mock1>>(dataJsonMulti10000Pretty);
        //}

        //[Benchmark]
        //public List<Mock1>? SpanJsonDeserializeUtf8Multi100000Compact()
        //{
        //    var array = Encoding.UTF8.GetBytes(dataJsonMulti100000Compact);
        //    var arraySpan = new Span<byte>(array);
        //    return SpanJson.JsonSerializer.Generic.Utf8.Deserialize<List<Mock1>>(arraySpan);
        //}

        //[Benchmark]
        //public List<Mock1>? SpanJsonDeserializeUtf16Multi100000Compact()
        //{
        //    return SpanJson.JsonSerializer.Generic.Utf16.Deserialize<List<Mock1>>(dataJsonMulti100000Compact);
        //}

        //[Benchmark]
        //public List<Mock1>? SpanJsonDeserializeUtf8Multi100000Pretty()
        //{
        //    var array = Encoding.UTF8.GetBytes(dataJsonMulti100000Pretty);
        //    var arraySpan = new Span<byte>(array);
        //    return SpanJson.JsonSerializer.Generic.Utf8.Deserialize<List<Mock1>>(arraySpan);
        //}

        //[Benchmark]
        //public List<Mock1>? SpanJsonDeserializeUtf16Multi100000Pretty()
        //{
        //    return SpanJson.JsonSerializer.Generic.Utf16.Deserialize<List<Mock1>>(dataJsonMulti100000Pretty);
        //}
    }
}