using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using smartography.BLL.Factories;
using smartography.BLL.Models;
using smartography.BLL.Readers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace smartography.BLL.Services
{
    public class PlaceService : IPlaceService
    {
        private const string CACHED_PLACES_KEY = "CachedPlaces";
        private readonly int _locationLimit;
        private readonly IMemoryCache _cache;
        private readonly IConfiguration _configuration;

        public PlaceService(IMemoryCache memoryCache, IConfiguration configuration)
        {
            _cache = memoryCache;
            _configuration = configuration;
            _locationLimit = int.TryParse(_configuration["LocationLimit"], out _locationLimit) ? _locationLimit : 5;
        }

        public IEnumerable<Place> GetPlaces(string filter)
        {
            return GetPlaces().Where(x => string.IsNullOrEmpty(filter)
                || x.Description.Contains(filter, StringComparison.OrdinalIgnoreCase)
                || x.Postcode.Contains(filter, StringComparison.OrdinalIgnoreCase)).Take(_locationLimit);
        }

        private IEnumerable<Place> GetPlaces()
        {

            if (!_cache.TryGetValue(CACHED_PLACES_KEY, out IEnumerable<Place> places))
            {
                var placeFactory = new PlaceFactory();
                var reader = new PlacesReader(placeFactory);

                var retrievedPlaces = reader.Read(@"Data\LocationData.csv");
                _cache.Set(CACHED_PLACES_KEY, retrievedPlaces);

                places = retrievedPlaces;
            }

            return places;
        }
    }
}
