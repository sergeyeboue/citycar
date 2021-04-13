using System;
using System.Collections.Generic;

namespace citycar.Models
{
    public class Proprietaire
    {
        public int Id { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public ICollection<Voiture> Voitures { get; set; } = new HashSet<Voiture>();
        public ICollection<Commentaire> Commentaire { get; set; } = new HashSet<Commentaire>();

    }

}
