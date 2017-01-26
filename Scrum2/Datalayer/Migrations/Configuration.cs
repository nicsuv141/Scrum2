namespace Datalayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Datalayer.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Datalayer.Models.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Datalayer.Models.DatabaseContext";
        }

        protected override void Seed(Datalayer.Models.DatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Users.AddOrUpdate(
                p => p.UserId,
                new User { Email = "admin@admin.com", FirstName = "Admin", LastName = "Adminsson", Password = "123456", Signature = "adm", Telephone = "01234567" },
                new User { Email = "a@b.com", FirstName = "A", LastName = "Ason", Password = "123456", Signature = "asn", Telephone = "01234567" }
            );

            //context.BlogEntries.AddOrUpdate(
            //    e => e.BlogEntryId,
            //    new BlogEntry { },
            //    new BlogEntry { },
            //);
        }
    }
}
