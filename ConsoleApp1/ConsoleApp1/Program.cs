// See https://aka.ms/new-console-template for more information
using DateOnlyTimeOnly.AspNet.Converters;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SampleApp;
public class SampleApp
{
    public static void Main()
    {
        TestModel a = new()
        {
            id = 1,
            value = new DateOnly()
        };
        string jsonString = JsonSerializer.Serialize(a);
        var b = JsonSerializer.Deserialize<TestModel>(jsonString);
        Console.WriteLine(b.value);
    }
    public class TestModel
    {
        public int id { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly value { get; set; }
    }
}
