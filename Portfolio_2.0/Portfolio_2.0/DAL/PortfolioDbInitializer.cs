using Portfolio_2._0.Migrations;
using Portfolio_2._0.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Portfolio_2._0.DAL
{
    class PortfolioDbInitializer: MigrateDatabaseToLatestVersion<PortfolioContext, Configuration>
    {
        public static void SeedPortfolioData(PortfolioContext context)
        {
            var languages = new List<Language>
            {
                new Language() {LanguageId=1 , LanguageName="pol"},
                new Language() {LanguageId=2,  LanguageName="eng"}
            };

            languages.ForEach(l => context.Languages.AddOrUpdate(l));
            context.SaveChanges();

            var pageElements = new List<PageElement>
            {
                new PageElement(){PageElementName="AboutMenu" },
                new PageElement(){PageElementName="ContactMenu" },
                new PageElement(){PageElementName="PortfolioMenu"},
                new PageElement(){PageElementName="LanguageLabel" }
            };
            pageElements.ForEach(pe => context.PageElements.AddOrUpdate(pe));
            context.SaveChanges();

            var technologies = new List<Technology>
            {
                new Technology(){TechnologyName="Asp",ImageFileName="Asp.png" },
                new Technology(){TechnologyName="Wpf",ImageFileName="Wpf.png" },
                new Technology(){TechnologyName="Bi",ImageFileName="Bi.png" },
                new Technology(){TechnologyName="VBA",ImageFileName="VBA.png" }
            };
            technologies.ForEach(t => context.Technologies.AddOrUpdate(t));
            context.SaveChanges();

            var projects = new List<Project>
            {
                new Project(){ProjectName="PortfolioAsp",ImageFileName="Portfolio.png",GitHubUrl= "https://github.com/milers/Portfolio_2.0",TechnologyId=1, Visible=true }

            };
            projects.ForEach(p => context.Projects.AddOrUpdate(p));
            context.SaveChanges();

            var translations = new List<Translation>
            {
                new Translation(){ ObjectId="AboutMenu",LanguageId=1, Name= "O mnie" },
                new Translation(){ ObjectId="ContactMenu",LanguageId=1, Name= "Kontakt" },
                new Translation(){ ObjectId="PortfolioMenu",LanguageId=1, Name= "Portfolio" },
                new Translation(){ ObjectId="AboutMenu",LanguageId=2, Name= "About" },
                new Translation(){ ObjectId="ContactMenu",LanguageId=2, Name= "Contact" },
                new Translation(){ ObjectId="PortfolioMenu",LanguageId=2, Name= "Portfolio" },

            };
            translations.ForEach(t => context.Translations.AddOrUpdate(t));
            context.SaveChanges();

        }
    }
}