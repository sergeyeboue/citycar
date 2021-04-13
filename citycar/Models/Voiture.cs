using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace citycar.Models
{

    public class Voiture
    {
        public int Id { get; set; }
        public String Marque { get; set; }
        public String Modele { get; set; }
        public int Cylindree { get; set; }
        public Double Prix { get; set; }

        public int ProprietaireId { get; set; }
        public ICollection<Commentaire> Commentaires { get; set; } = new HashSet<Commentaire>();

    }

}
