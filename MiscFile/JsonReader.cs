using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace software_assignment
{
    public class JsonReader
    {
        public static string GetTestData(string key)
        {
            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "DataFile",
                "Data.json"
            );

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(
                    "Test data file was not found.",
                    filePath
                );
            }

            JObject data = JObject.Parse(
                File.ReadAllText(filePath)
            );

            string? value = data["LoginData"]?[key]?.ToString();

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new InvalidOperationException(
                    $"Test data '{key}' is missing from Data.json."
                );
            }

            return value;
        }
    }
}