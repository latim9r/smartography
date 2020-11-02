using smartography.BLL.Models;
using System;

namespace smartography.BLL.Factories
{
    public class PlaceFactory : ObjectFactory<Place>
    {
        public override Place Create(string row)
        {
            var placeElements = row.Split(',');

            return new Place
            {
                Id = int.Parse(placeElements[0]),
                Latitude = placeElements[1],
                Longitude = placeElements[2],
                Postcode = placeElements[3],
                Description = placeElements[4],
            };
        }
    }
}
