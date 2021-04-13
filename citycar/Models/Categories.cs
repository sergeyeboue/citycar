using System;
using System.Collections.Generic;

namespace citycar.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public String Nom { get; set; }
        public ICollection<Voiture> Voitures { get; set; } = new HashSet<Voiture>();
    }

}
