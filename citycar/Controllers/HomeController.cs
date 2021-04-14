using citycar.Data;
using citycar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace citycar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Voitures
                .Include(x => x.Proprietaire)
                .Include(x => x.Categorie)
                .Include(x => x.Commentaires)
                .ToListAsync());
        }

        //afficher en fonction de la recherche
        [HttpPost]
        public async Task<IActionResult> Index(Voiture car, Categories categories)
        {
            if (car.Marque == null && categories.NomCategories == null)
            {
                return View(await _context.Voitures
                .Include(x => x.Proprietaire)
                .Include(x => x.Categorie)
                .Include(x => x.Commentaires)
                .ToListAsync());
            }
            if (car.Marque != null && categories.NomCategories == null)
            {
                var voiture = await _context.Voitures
                 .Include(x => x.Proprietaire)
                 .Include(x => x.Categorie)
                 .Include(x => x.Commentaires)
                 .Where(x => x.Marque == car.Marque)
                 .ToListAsync();
                return View(voiture);
            }
            if (car.Marque == null && categories.NomCategories != null)
            {
                var voiture = await _context.Voitures
                 .Include(x => x.Proprietaire)
                 .Include(x => x.Categorie)
                 .Include(x => x.Commentaires)
                 .Where(x => x.Categorie.NomCategories == categories.NomCategories)
                 .ToListAsync();
                return View(voiture);
            }
            else
            {
                var voiture = await _context.Voitures
               .Include(x => x.Proprietaire)
               .Include(x => x.Categorie).Where(x => x.Categorie.NomCategories == categories.NomCategories)
               .Include(x => x.Commentaires)
               .Where(x => x.Marque == car.Marque)
               .ToListAsync();
                return View(voiture);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
