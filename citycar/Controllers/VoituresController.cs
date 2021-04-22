
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using citycar.Data;
using citycar.Models;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace citycar.Controllers
{
    public class VoituresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VoituresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Voitures
        public async Task<IActionResult> Index()
        {
            return View(await _context.Voitures.Include(x => x.Proprietaire).Include(x => x.Categorie).ToListAsync());
        }

        // GET: Voitures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                ViewData["exceptionVoitureId"] = "Impossible de traiter cette demande !!!";
                return View();
            }

            var voiture = await _context.Voitures
                .Include(x => x.Proprietaire)
                .Include(x => x.Categorie)
                .Include(x => x.Commentaires)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (voiture == null)
            {
                ViewData["exceptionVoitureId"] = "Cet id " + (id) + " n'existe pas ";
                return View();
            }

            return View(voiture);
        }

        // GET: Voitures/Create
        public IActionResult Create(int? id)
        {
            Proprietaire proprietaire = null;
            if (id != null)
            {
                 proprietaire = _context.Proprietaire.Where(x => x.Id == id).FirstOrDefault();
                if (proprietaire != null) 
                    ViewData["Proprietaire"] = proprietaire;
            }
            return View();
        }

        // POST: Voitures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Marque,Modele,Cylindree,Prix,Image")] Voiture voiture, Categories categories, Proprietaire proprietaire)
        {
            if (ModelState.IsValid)
            {
                //recupere l'image passer dans le formulaire
                
                if(Request.Form.Files.Count > 0)
                {
                    var file = Request.Form.Files[0];
                    var filePath = @"wwwroot/img/" + file.FileName;
                    using var stream = System.IO.File.Create(filePath);
                    await file.CopyToAsync(stream);
                    voiture.Image = file.FileName;
                }
                
                //Recupere tous les proprietes de la voiture avant l'insertion                
                voiture.Categorie = _context.Categories.FirstOrDefault(x => x.NomCategories == categories.NomCategories);
                if(_context.Proprietaire.Any(x => x.Id == proprietaire.Id))
                {
                    voiture.Proprietaire =  _context.Proprietaire.FirstOrDefault(x => x.Id == proprietaire.Id);

                }
                if(proprietaire.Id == 0)
                {
                     _context.Proprietaire.Add(proprietaire);
                    await _context.SaveChangesAsync();
                    voiture.Proprietaire =  await _context.Proprietaire.OrderByDescending(x => x.Id).FirstAsync();
                }
                // id autoincrement !
                voiture.Id = 0;
                


                _context.Add(voiture);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(voiture);
        }

        // GET: Voitures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                ViewData["exceptionVoitureId"] = "Impossible de traiter cette demande !!!";
                return View();
            }

            var voiture = await _context.Voitures
                .Include(x => x.Proprietaire)
                .Include(x => x.Categorie)
                .Include(x => x.Commentaires)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (voiture == null)
            {
                ViewData["exceptionVoitureId"] = "Impossible de trouver cet Id " + id;
                return View();
            }
            return View(voiture);
        }

        // POST: Voitures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Marque,Modele,Cylindree,Prix,Image")] Voiture voiture, String FisrtNameImage, String CategorieId, String ProprietaireId)
        {
            
            if (id != voiture.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                //Si on a un nouveau fichier on supprimer l'ancien du serveur
                if(Request.Form.Files.Count > 0)
                {
                    
                    if(FisrtNameImage != null)
                    {
                        var aFilePath = @"wwwroot/img/" + FisrtNameImage;
                        try
                        {
                            System.IO.File.Delete(aFilePath);
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                    
                    //recupere l'image passer dans le formulaire
                    var file = Request.Form.Files[0];
                    if (file.Length > 0)
                    {
                        var filePath = @"wwwroot/img/" + file.FileName;
                        using var stream = System.IO.File.Create(filePath);
                        await file.CopyToAsync(stream);
                    }
                    voiture.Image = file.FileName;
                }
                else { voiture.Image = FisrtNameImage; }

                
                //Recupere tous les proprietes de la voiture avant l'insertion                
                voiture.Proprietaire = await _context.Proprietaire.Where(x => x.Id == int.Parse(ProprietaireId)).FirstAsync();
                voiture.Categorie = await _context.Categories.Where(x => x.Id == int.Parse(CategorieId)).FirstAsync();                 



                try
                {
                    _context.Update(voiture);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VoitureExists(voiture.Id))
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
            return View(voiture);
        }

        // GET: Voitures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                ViewData["exceptionVoitureId"] = "Impossible de traiter cette demande !!!";
                return View();
            }

            var voiture = await _context.Voitures
                .FirstOrDefaultAsync(m => m.Id == id);
            if (voiture == null)
            {
                ViewData["exceptionVoitureId"] = "Impossible de trouver cet Id " + id;
                return View(voiture);

            }

            return View(voiture);
        }

        // POST: Voitures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //suppresion des commentaire de la voiture  
            var listCommentaire = await _context.Commentaire.Where(x => x.Voiture.Id == id).ToListAsync();
            if(listCommentaire != null)
            {
                foreach (var c in listCommentaire)
                {
                    _context.Commentaire.Remove(c);

                }
                await _context.SaveChangesAsync();
            }


            if (VoitureExists(id))
            {
                var voiture = await _context.Voitures.FindAsync(id);
                _context.Voitures.Remove(voiture);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewData["exceptionVoitureId"] = " Cette voiture n'existe pas";
                return View();
            }



        }

        private bool VoitureExists(int id)
        {
            return _context.Voitures.Any(e => e.Id == id);
        }
    }
}
