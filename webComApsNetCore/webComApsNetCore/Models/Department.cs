using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace webComApsNetCore.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        public string Nome { get; set; }

        public Department() { }
        public Department(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void CreateExcel()
        {
            var lines = new List<string>();

            //string[] columnNames = dt.Columns
            //    .Cast<DataColumn>()
            //    .Select(column => column.ColumnName)
            //    .ToArray();

            //var header = string.Join(",", columnNames.Select(name => $"\"{name}\""));
            //lines.Add(header);

            //var valueLines = dt.AsEnumerable()
            //    .Select(row => string.Join(",", row.ItemArray.Select(val => $"\"{val}\"")));

            for (int i=0;i<10;i++)
            {
                var valueLines = new List<string>();
                valueLines.Add($"James  Miles   james@abcd.com  9876543210  email");
                lines.AddRange(valueLines);
            }

            File.WriteAllLines("excel.csv", lines);
        }
    }
}
