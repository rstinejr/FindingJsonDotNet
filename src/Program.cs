using System;
using System.IO;
using System.Text;

using Newtonsoft.Json;

namespace FindingJsonDotNet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StringWriter sw = new StringWriter(new StringBuilder());
            JsonWriter   jw = new JsonTextWriter(sw);

            jw.WriteStartObject();
            jw.WritePropertyName("School");
            jw.WriteValue("University of Alabama");
            jw.WritePropertyName("Sport");
            jw.WriteValue("Football");
            jw.WritePropertyName("Ranking");
            jw.WriteValue(1);
            jw.WriteEndObject();

            Console.WriteLine($"Roll Tide! {sw.ToString()}");
        }
    }
}
