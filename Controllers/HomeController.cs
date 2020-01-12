using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SupWave.Models;

namespace SupWave.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string audioDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/audio");

            List<string> musicNames = new List<string>();
            List<string> musicPaths = new List<string>();
            foreach (string filepath in Directory.GetFiles(audioDirectory))
            {
                string filename = Path.GetFileName(filepath);
                if(filename != ".gitignore")
                {
                    musicNames.Add(filename); 
                    musicPaths.Add(filepath);
                }
            }

            ViewBag.musics = musicNames;
            ViewBag.paths = musicPaths;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
