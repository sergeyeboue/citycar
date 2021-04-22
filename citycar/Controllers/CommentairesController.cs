using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using citycar.Data;
using citycar.Models;
using System.Text.RegularExpressions;

namespace citycar.Controllers
{
    public class CommentairesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CommentairesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // POST: Commentaires/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TextCommentaire,Date")] Commentaire commentaire, Voiture voiture)
        {
            commentaire.TextCommentaire = StripHTML(commentaire.TextCommentaire);
            
            commentaire.Voiture = _context.Voitures.FirstOrDefault(m => m.Id == voiture.Id);
            commentaire.Id = 0;
            

            if (ModelState.IsValid)
            {
                _context.Add(commentaire);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Voitures", new { id = voiture.Id });
            }
            return RedirectToAction("Details", "Voitures", new { id = voiture.Id });
        }

        // POST: Commentaires/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var commentaire = await _context.Commentaire.FindAsync(id);
            _context.Commentaire.Remove(commentaire);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommentaireExists(int id)
        {
            return _context.Commentaire.Any(e => e.Id == id);
        }
        public static string StripHTML(string input)
        {
            return Regex.Replace(input, "<.*?>", String.Empty);
        }

    }
}
