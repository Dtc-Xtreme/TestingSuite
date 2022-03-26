using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestingSuite.Models
{
    [JsonSerializable(typeof(List<Mock1>))]
    [JsonSourceGenerationOptions(GenerationMode = JsonSourceGenerationMode.Default, PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
    public partial class Mock1JsonSerializerContext : JsonSerializerContext
    {
    }
}
