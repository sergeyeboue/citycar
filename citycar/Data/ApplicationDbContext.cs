using citycar.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace citycar.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Voiture> Voitures { get; set; }
        public DbSet<citycar.Models.Proprietaire> Proprietaire { get; set; }
        public DbSet<citycar.Models.Categories> Categories { get; set; }
        public DbSet<citycar.Models.Commentaire> Commentaire { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region seeVoiture
            modelBuilder.Entity<Voiture>()
                .HasData(
                    new
                    {

                        Id = 1,
                        Marque = "Mercedes",
                        Modele = "G-class 2021",
                        Cylindree = 8,
                        Prix = 500_000.00,
                        Image = "1.jpg",
                        ProprietaireId = 1,
                        CategorieId = 2
                    }
                    );

            modelBuilder.Entity<Voiture>()
                .HasData(
                    new
                    {

                        Id = 2,
                        Marque = "BMW",
                        Modele = "X6 2019",
                        Cylindree = 6,
                        Prix = 30_000.00,
                        Image = "2.jpg",
                        ProprietaireId = 1,
                        CategorieId = 2
                    }
                    );

            modelBuilder.Entity<Voiture>()
                .HasData(
                    new
                    {

                        Id = 3,
                        Marque = "lamborghini",
                        Modele = "Urus 2020",
                        Cylindree = 8,
                        Prix = 150_000.00,
                        Image = "3.jpg",
                        ProprietaireId = 2,
                        CategorieId = 2
                    }
                    );

            modelBuilder.Entity<Voiture>()
                .HasData(
                    new
                    {

                        Id = 4,
                        Marque = "Ford",
                        Modele = "Explorer 2018",
                        Cylindree = 8,
                        Prix = 50_000.00,
                        Image = "4.jpg",
                        ProprietaireId = 2,
                        CategorieId = 2
                    }
                    );
            modelBuilder.Entity<Voiture>()
                .HasData(
                    new
                    {

                        Id = 5,
                        Marque = "Ferrari",
                        Modele = "458 Italia",
                        Cylindree = 8,
                        Prix = 50_000.00,
                        Image = "5.jpg",
                        ProprietaireId = 2,
                        CategorieId = 1
                    }
                    );
            modelBuilder.Entity<Voiture>()
                .HasData(
                    new
                    {

                        Id = 6,
                        Marque = "McLaurent",
                        Modele = "720s",
                        Cylindree = 8,
                        Prix = 350_000.00,
                        Image = "6.jpg",
                        ProprietaireId = 1,
                        CategorieId = 1
                    }
                    );
            modelBuilder.Entity<Voiture>()
                .HasData(
                    new
                    {

                        Id = 7,
                        Marque = "Ford",
                        Modele = "720s",
                        Cylindree = 8,
                        Prix = 26549.00,
                        Image = "7.jpg",
                        ProprietaireId = 3,
                        CategorieId = 3
                    }
                    );
            modelBuilder.Entity<Voiture>()
                .HasData(
                    new
                    {

                        Id = 8,
                        Marque = "Jeep",
                        Modele = "kjcx8",
                        Cylindree = 8,
                        Prix = 30549.00,
                        Image = "8.jpg",
                        ProprietaireId = 4,
                        CategorieId = 4
                    }
                    );
            #endregion


            #region seeProprietaire
            modelBuilder.Entity<Proprietaire>()
                .HasData(
                    new
                    {
                        Id = 1,
                        Nom = "Servais",
                        Prenom = "Jean"
                    }
                    );
            modelBuilder.Entity<Proprietaire>()
                .HasData(
                    new
                    {
                        Id = 2,
                        Nom = "Dupont",
                        Prenom = "Luc"
                    }
                    );
            modelBuilder.Entity<Proprietaire>()
                .HasData(
                    new
                    {
                        Id = 3,
                        Nom = "Richard",
                        Prenom = "Johns"
                    }
                    );
            modelBuilder.Entity<Proprietaire>()
                .HasData(
                    new
                    {
                        Id = 4,
                        Nom = "Xavier",
                        Prenom = "Mensah"
                    }
                    );
            #endregion

            #region seeCategorie
            modelBuilder.Entity<Categories>()
                .HasData(
                    new
                    {
                        Id = 1,
                        NomCategories = "Berline"
                    }
                    );
            modelBuilder.Entity<Categories>()
                .HasData(
                    new
                    {
                        Id = 2,
                        NomCategories = "SUV"
                    }
                    );
            modelBuilder.Entity<Categories>()
                .HasData(
                    new
                    {
                        Id = 3,
                        NomCategories = "Roadster"
                    }
                    );
            modelBuilder.Entity<Categories>()
                .HasData(
                    new
                    {
                        Id = 4,
                        NomCategories = "Cabriolet"
                    }
                    );
            modelBuilder.Entity<Categories>()
                .HasData(
                    new
                    {
                        Id = 5,
                        NomCategories = "Familiale"
                    }
                    );
            modelBuilder.Entity<Categories>()
                .HasData(
                    new
                    {
                        Id = 6,
                        NomCategories = "Coupé"
                    }
                    );
            modelBuilder.Entity<Categories>()
                .HasData(
                    new
                    {
                        Id = 7,
                        NomCategories = "Pickup"
                    }
                    );
            modelBuilder.Entity<Categories>()
                .HasData(
                    new
                    {
                        Id = 8,
                        NomCategories = "voiture sportive"
                    }
                    );
            modelBuilder.Entity<Categories>()
                .HasData(
                    new
                    {
                        Id = 9,
                        NomCategories = "4×4"
                    }
                    );
            #endregion

            #region seeCommentaire
            modelBuilder.Entity<Commentaire>()
                .HasData(
                    new
                    {
                        Id = 1,
                        TextCommentaire = "Premier commentaire",
                        Date = DateTime.Now,
                        VoitureId = 1
                    }
                    );

            modelBuilder.Entity<Commentaire>()
                .HasData(
                    new
                    {
                        Id = 2,
                        TextCommentaire = "Un Autre commentaire",
                        Date = DateTime.Now,
                        VoitureId = 2
                    }
                    );

            modelBuilder.Entity<Commentaire>()
                .HasData(
                    new
                    {
                        Id = 3,
                        TextCommentaire = "Encore un Autre commentaire",
                        Date = DateTime.Now,
                        VoitureId = 3
                    }
                    );
            modelBuilder.Entity<Commentaire>()
                .HasData(
                    new
                    {
                        Id = 4,
                        TextCommentaire = "Encore un Autre commentaire",
                        Date = DateTime.Now,
                        VoitureId = 4
                    }
                    );
            modelBuilder.Entity<Commentaire>()
                .HasData(
                    new
                    {
                        Id = 5,
                        TextCommentaire = "Encore un Autre commentaire",
                        Date = DateTime.Now,
                        VoitureId = 5
                    }
                    );
            modelBuilder.Entity<Commentaire>()
                .HasData(
                    new
                    {
                        Id = 6,
                        TextCommentaire = "Encore un Autre commentaire",
                        Date = DateTime.Now,
                        VoitureId = 6
                    }
                    );
            #endregion
        }


    }
}
