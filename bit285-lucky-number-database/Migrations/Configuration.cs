namespace bit285_lucky_number_database.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<bit285_lucky_number_database.Models.LuckyNumberDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "bit285_lucky_number_database.Models.LuckyNumberDbContext";
        }

        protected override void Seed(bit285_lucky_number_database.Models.LuckyNumberDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
