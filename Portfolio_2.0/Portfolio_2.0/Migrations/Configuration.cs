namespace Portfolio_2._0.Migrations

{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Portfolio_2._0.DAL;

    internal sealed class Configuration : DbMigrationsConfiguration<Portfolio_2._0.DAL.PortfolioContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Portfolio_2._0.DAL.PortfolioContext context)
        {
            PortfolioDbInitializer.SeedPortfolioData(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
