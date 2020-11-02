using smartography.BLL.Models;
using System.Collections.Generic;

namespace smartography.BLL.Services
{
    public interface IPlaceService
    {
        IEnumerable<Place> GetPlaces(string filter);
    }
}
