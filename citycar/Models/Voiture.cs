using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace citycar.Models
{

    public class Voiture
    {

        public int Id { get; set; }
        [Required, StringLength(250, MinimumLength = 3)]
        public String Marque { get; set; }
        [Required, StringLength(250, MinimumLength = 3)]
        public String Modele { get; set; }
        [Required]
        public int Cylindree { get; set; }
        [Required]
        [DataType(DataType.Currency)]
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
        [Required, StringLength(250, MinimumLength = 3)]
        public String Nom { get; set; }
        [Required, StringLength(250, MinimumLength = 3)]
        public String Prenom { get; set; }
        [Required, StringLength(250, MinimumLength = 3)]
        public String NomComplet => $"{Nom} {Prenom}";
        public ICollection<Voiture> Voitures { get; set; } = new HashSet<Voiture>();

    }
    public class Categories
    {
        public int Id { get; set; }
        [Required, StringLength(60, MinimumLength = 3)]
        public String NomCategories { get; set; }
        public ICollection<Voiture> Voitures { get; set; } = new HashSet<Voiture>();
    }

    public class Commentaire
    {
        public int Id { get; set; }
        [Required, StringLength(500, MinimumLength = 3)]
        public String TextCommentaire { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public Voiture Voiture { get; set; }
    }

}
