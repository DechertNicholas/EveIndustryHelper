using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using SQLiteDBHandler.Models;

namespace SQLiteDBHandler
{
    class YamlImporter
    {
        static void Main()
        {
            var sampleYaml = System.IO.File.ReadAllText(@".\YamlSample.txt",Encoding.UTF8);
            Console.OutputEncoding = Encoding.Default;
            Console.WriteLine(sampleYaml);

            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            var testShip = deserializer.Deserialize<Ship>(sampleYaml);
            Console.WriteLine(testShip);
        }
    }
}
