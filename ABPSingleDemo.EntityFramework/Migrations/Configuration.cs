namespace ABPSingleDemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ABPSingleDemo.EntityFramework.ABPSingleDemoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ABPSingleDemo";
        }

        protected override void Seed(ABPSingleDemo.EntityFramework.ABPSingleDemoDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
