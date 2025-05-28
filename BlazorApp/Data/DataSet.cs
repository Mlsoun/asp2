using BlazorApp.Model;
using System.IO;
using System.Text.Json;

namespace BlazorApp.Data
{
    public class DataSet
    {
        private List<Person> data = null;
        public List<Person> GetData()
        {
            if (data == null)
            {
                var path = @"C:\Users\Student EN\source\repos\asp2\data2024.json";
                var jsonString = File.ReadAllText(path);
                data = JsonSerializer.Deserialize<List<Person>>(jsonString);
            }

            return data;
        }

    }
}
