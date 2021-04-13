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
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<citycar.Models.Proprietaire> Proprietaire { get; set; }
        public DbSet<citycar.Models.Categories> Categories { get; set; }
        public DbSet<citycar.Models.Commentaire> Commentaire { get; set; }

    }
}
