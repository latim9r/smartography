using smartography.BLL.Factories;
using smartography.BLL.Models;

namespace smartography.BLL.Readers
{
    public class PlacesReader : CsvReader<Place>
    {
        public PlacesReader(ObjectFactory<Place> objectFactory) : base(objectFactory)
        {
        }
    }
}
