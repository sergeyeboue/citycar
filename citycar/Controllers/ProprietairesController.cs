using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using citycar.Data;
using citycar.Models;

namespace citycar.Controllers
{
    public class ProprietairesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProprietairesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Proprietaires
        public async Task<IActionResult> Index()
        {
            return View(await _context.Proprietaire.ToListAsync());
        }

        // GET: Proprietaires/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proprietaire = await _context.Proprietaire
                .Include(x => x.Voitures)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proprietaire == null)
            {
                return NotFound();
            }

            return View(proprietaire);
        }

        // GET: Proprietaires/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Proprietaires/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,Prenom")] Proprietaire proprietaire)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proprietaire);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(proprietaire);
        }

        // GET: Proprietaires/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proprietaire = await _context.Proprietaire.FindAsync(id);
            if (proprietaire == null)
            {
                return NotFound();
            }
            return View(proprietaire);
        }

        // POST: Proprietaires/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Prenom")] Proprietaire proprietaire)
        {
            if (id != proprietaire.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proprietaire);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProprietaireExists(proprietaire.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(proprietaire);
        }

        // GET: Proprietaires/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proprietaire = await _context.Proprietaire
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proprietaire == null)
            {
                return NotFound();
            }

            return View(proprietaire);
        }

        // POST: Proprietaires/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //suppression en cascade !!

            //On va recuperer la list de ses voitures.
            var listVoiture = await _context.Voitures.Where(x => x.Proprietaire.Id == id).ToListAsync();

            //Supprimer les commentaires de ses voitures et les voitures
            if (listVoiture != null)
            {
                foreach (var v in listVoiture)
                {
                    var listCommentaire = await _context.Commentaire.Where(x => x.Voiture.Id == v.Id).ToListAsync();
                    if(listCommentaire != null)
                    {
                        foreach (var c in listCommentaire)
                        {
                            _context.Commentaire.Remove(c);                            
                        }
                        await _context.SaveChangesAsync();
                    }
                    _context.Voitures.Remove(v);

                }

                await _context.SaveChangesAsync();
            }

            //Supprime le proprietaire !

            var proprietaire = await _context.Proprietaire.FindAsync(id);
            _context.Proprietaire.Remove(proprietaire);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProprietaireExists(int id)
        {
            return _context.Proprietaire.Any(e => e.Id == id);
        }
    }
}
