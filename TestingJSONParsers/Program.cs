using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using System.Text;
using TestingSuite.Models;
using TestingSuite.Tests;

namespace TestingSuite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var summary1 = BenchmarkRunner.Run(typeof(SerializeMock1Test));
            ////var summary2 = BenchmarkRunner.Run(typeof(SerializeMock2Test));
            ////var summary3 = BenchmarkRunner.Run(typeof(SerializeMock3Test));
            ////var summary4 = BenchmarkRunner.Run(typeof(SerializeMock4Test));

            //var summary5 = BenchmarkRunner.Run(typeof(DeserializeMock1Test));
            ////var summary6 = BenchmarkRunner.Run(typeof(DeserializeMock2Test));
            ////var summary7 = BenchmarkRunner.Run(typeof(DeserializeMock3Test));
            ////var summary8 = BenchmarkRunner.Run(typeof(DeserializeMock4Test));

            //var summary9 = BenchmarkRunner.Run(typeof(ArrayTest));

            var summary10 = BenchmarkRunner.Run(typeof(JsonSerializerContextTest));

            var summary11 = BenchmarkRunner.Run(typeof(SpanJsonUTfTest));

        }
    }
}