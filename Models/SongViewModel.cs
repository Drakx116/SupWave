using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupWave.Models
{
    public class SongViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Singer { get; set; }

        public IFormFile Media { get; set; }
    }
}
