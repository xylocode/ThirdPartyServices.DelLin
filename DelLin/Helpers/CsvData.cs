using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;

namespace XyloCode.ThirdPartyServices.DelLin.Helpers
{
    internal class CsvData
    {
        TextFieldParser csv;
        string[] fields;
        int[] map;


        public CsvData(MemoryStream memoryStream, string[] headers = null)
        {
            memoryStream.Position = 0;
            csv = new TextFieldParser(memoryStream)
            {
                TextFieldType = FieldType.Delimited,
                Delimiters = new string[] { "," },
                HasFieldsEnclosedInQuotes = true,
                TrimWhiteSpace = true,
            };

            if (headers is not null)
            {
                fields = csv.ReadFields();

                map = new int[headers.Length];
                for (int i = 0; i < map.Length; i++)
                {
                    map[i] = Array.IndexOf(fields, headers[i]);

                    if (map[i] < 0)
                        throw new Exception($"Заголовок [{headers[i]}] не найден.");
                }
            }
            else
            {
                map = new int[32];
                for (int i = 0; i < map.Length; i++)
                    map[i] = i;
            }
        }
        
        public bool Read()
        {
            if (csv.EndOfData)
                return false;

            fields = csv.ReadFields();
            return true;
        }

        public string this[int index] => fields[map[index]];
    }
}
