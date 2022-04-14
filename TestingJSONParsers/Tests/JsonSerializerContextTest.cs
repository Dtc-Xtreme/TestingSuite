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
    //[SimpleJob(launchCount: 1, warmupCount: 5, targetCount: 5)]
    [SimpleJob(launchCount: 10, warmupCount: 50, targetCount: 25)]

    public class JsonSerializerContextTest
    {
        private readonly List<Mock1>? dataSingleCompact;
        private readonly List<Mock1>? dataMulti1000Compact;
        private readonly List<Mock1>? dataMulti10000Compact;
        private readonly List<Mock1>? dataMulti100000Compact;

        public JsonSerializerContextTest()
        {
            this.dataSingleCompact = Tools.CreateMockObjectsX<Mock1>(1, 'C', false);
            this.dataMulti1000Compact = Tools.CreateMockObjectsX<Mock1>(1000, 'C', false);
            this.dataMulti10000Compact = Tools.CreateMockObjectsX<Mock1>(10000, 'C', false);
            this.dataMulti100000Compact = Tools.CreateMockObjectsX<Mock1>(100000, 'C', false);
        }

        // Serializing //
        // System.Text.Json met context//

        [Benchmark]
        public string SystemTextJsonSerializeSingleCompactWithContext()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataSingleCompact, Mock1JsonSerializerContext.Default.ListMock1);
        }

        [Benchmark]
        public string SystemTextJsonSerializeMulti1000CompactWithContext()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti1000Compact, Mock1JsonSerializerContext.Default.ListMock1);
        }

        [Benchmark]
        public string SystemTextJsonSerializeMulti10000CompactWithContext()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti10000Compact, Mock1JsonSerializerContext.Default.ListMock1);
        }

        [Benchmark]
        public string SystemTextJsonSerializeMulti100000CompactWithContext()
        {
            return System.Text.Json.JsonSerializer.Serialize(dataMulti100000Compact, Mock1JsonSerializerContext.Default.ListMock1);
        }
    }
}