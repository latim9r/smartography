using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartography.BLL.Models
{
    public class Place
    {
        public int Id { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string Postcode { get; set; }

        public string Description { get; set; }
    }
}
