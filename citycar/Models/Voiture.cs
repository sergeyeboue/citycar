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
        public String Image { get; set; }
        public String InfoVoiture => $"{Marque} {Modele}";

        public Proprietaire Proprietaire { get; set; }
        public ICollection<Commentaire> Commentaires { get; set; } = new HashSet<Commentaire>();

        public Categories Categorie { get; set; }

    }
    public class Proprietaire
    {
        public int Id { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public String NomComplet => $"{Nom} {Prenom}";
        public ICollection<Voiture> Voitures { get; set; } = new HashSet<Voiture>();

    }
    public class Categories
    {
        public int Id { get; set; }
        public String NomCategories { get; set; }
        public ICollection<Voiture> Voitures { get; set; } = new HashSet<Voiture>();
    }

    public class Commentaire
    {
        public int Id { get; set; }
        public String TextCommentaire { get; set; }
        public DateTime Date { get; set; }
        public Voiture Voiture { get; set; }
    }
}
