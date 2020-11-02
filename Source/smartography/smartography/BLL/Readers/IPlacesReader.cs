using smartography.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartography.BLL.Readers
{
    public interface IPlacesReader
    {
        IEnumerable<Place> GetPlaces(string filter);
    }
}
