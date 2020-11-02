using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using smartography.BLL.Models;
using smartography.BLL.Services;

namespace smartography.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        private readonly IPlaceService _placeService;
        public PlacesController(IPlaceService placeService)
        {
            _placeService = placeService;
        }

        [HttpGet]
        public IEnumerable<Place> Get(string filter)
        {
            return _placeService.GetPlaces(filter);
        }
    }
}   
