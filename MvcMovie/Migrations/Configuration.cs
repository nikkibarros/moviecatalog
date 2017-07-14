namespace MvcMovie.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcMovie.Models.MovieDbContext context)
        {
            context.Movies.AddOrUpdate(m => m.Title,
                new Movie
                {
                    Title = "Deepwater Horizon",
                    ReleaseDate = DateTime.Parse("2016-9-30"),
                    Genre = "Disaster",
                    Price = 7.99M,
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Empire of the Sun",
                    ReleaseDate = DateTime.Parse("1987-12-25"),
                    Genre = "War",
                    Price = 8.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Marley & Me",
                    ReleaseDate = DateTime.Parse("2008-12-25"),
                    Genre = "Drama",
                    Price = 8.49M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Up in the Air",
                    ReleaseDate = DateTime.Parse("2009-12-4"),
                    Genre = "Drama",
                    Price = 3.99M,
                    Rating = "R"
                });
        }
    }
}
