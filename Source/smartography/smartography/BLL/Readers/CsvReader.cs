using smartography.BLL.Factories;
using System.Collections.Generic;
using System.IO;

namespace smartography.BLL.Readers
{
    public class CsvReader<T>
    {
        private readonly ObjectFactory<T> _objectFactory;

        public CsvReader(ObjectFactory<T> objectFactory)
        {
            _objectFactory = objectFactory;
        }

        public IEnumerable<T> Read(string fileName)
        {
            var result = new List<T>();
            using (var reader = new StreamReader(fileName))
            {
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    result.Add(GetObjectFromRow(line));
                }
            }

            return result;
        }

        private T GetObjectFromRow(string row)
        {
            return _objectFactory.Create(row);
        }
    }
}
