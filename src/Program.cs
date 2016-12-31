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

            // Note property misalignment: Class 'CollegeSport' does not have "Ranking", JSON does not have "City".

            CollegeSport fromJson = JsonConvert.DeserializeObject<CollegeSport>(sw.ToString());

            Console.WriteLine($"Deserialized: {fromJson}");
        }
    }

    class CollegeSport
    {
        public string School { get; set; }
        public string Sport  { get; set; }
        public string City   { get; set; }

        public override string ToString()
        {
            return $"School '{School}', Sport '{Sport}', City: '{City}'";
        }
    }
}
