using Portfolio_2._0.Migrations;
using Portfolio_2._0.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Portfolio_2._0.DAL
{
    public class PortfolioContext: DbContext
    {
        public PortfolioContext() : base("PortfolioContext")
        {  
        }
        static PortfolioContext()
        {
            Database.SetInitializer<PortfolioContext>(new PortfolioDbInitializer());
        }

        public DbSet<Language> Languages { get; set; }
        public DbSet<PageElement> PageElements { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<Translation> Translations { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            // using System.Data.Entity.ModelConfiguration.Conventions;
            // Wyłącza konwencję, która automatycznie tworzy liczbę mnogą dla nazw tabel w bazie danych
            // Zamiast Kategorie zostałaby stworzona tabela o nazwie Kategories
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
            
        }
    }
}