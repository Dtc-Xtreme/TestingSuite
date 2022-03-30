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
    //[SimpleJob(launchCount: 10, warmupCount: 50, targetCount: 25)]

    public class SpanJsonUTfTest
    {
        private readonly List<Mock1>? dataSingleCompact;
        private readonly List<Mock1>? dataMulti1000Compact;
        private readonly List<Mock1>? dataMulti10000Compact;
        private readonly List<Mock1>? dataMulti100000Compact;
        private readonly string dataSimpleJsonCompact;
        private readonly string dataSimpleJsonPretty;
        private readonly string dataJsonMulti1000Compact;
        private readonly string dataJsonMulti1000Pretty;
        private readonly string dataJsonMulti10000Compact;
        private readonly string dataJsonMulti10000Pretty;
        private readonly string dataJsonMulti100000Compact;
        private readonly string dataJsonMulti100000Pretty;


        public SpanJsonUTfTest()
        {
            this.dataSingleCompact = Tools.CreateMockObjectsX<Mock1>(1, 'C');
            this.dataMulti1000Compact = Tools.CreateMockObjectsX<Mock1>(1000, 'C');
            this.dataMulti10000Compact = Tools.CreateMockObjectsX<Mock1>(10000, 'C');
            this.dataMulti100000Compact = Tools.CreateMockObjectsX<Mock1>(100000, 'C');
            this.dataSimpleJsonCompact = Tools.LoadJSONFile(Tools.dirOfFiles + Tools.fileSingleCompact);
            this.dataSimpleJsonPretty = Tools.LoadJSONFile(Tools.dirOfFiles + Tools.fileSinglePretty);
            this.dataJsonMulti1000Compact = Tools.LoadJSONFile(Tools.dirOfFiles + Tools.fileMulti1000Compact);
            this.dataJsonMulti1000Pretty = Tools.LoadJSONFile(Tools.dirOfFiles + Tools.fileMulti1000Pretty);
            this.dataJsonMulti10000Compact = Tools.LoadJSONFile(Tools.dirOfFiles + Tools.fileMulti10000Compact);
            this.dataJsonMulti10000Pretty = Tools.LoadJSONFile(Tools.dirOfFiles + Tools.fileMulti10000Pretty);
            this.dataJsonMulti100000Compact = Tools.LoadJSONFile(Tools.dirOfFiles + Tools.fileMulti100000Compact);
            this.dataJsonMulti100000Pretty = Tools.LoadJSONFile(Tools.dirOfFiles + Tools.fileMulti100000Pretty);
        }


        // SpanJson Serializing UTF //
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


        // SpanJson Deserialize UTF //
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