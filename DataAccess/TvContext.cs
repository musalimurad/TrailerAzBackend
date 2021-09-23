using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class TvContext : IdentityDbContext<User>
    {
        public TvContext(DbContextOptions<TvContext> options) : base(options)
        {

        }

        public DbSet<Category> categories { get; set; }

        public DbSet<Country> countries { get; set; }

        public DbSet<TvShow> tvShows { get; set; }

        public DbSet<TvShowSeason> tvShowSeasons { get; set; }

        public DbSet<TvShowSerie> tvShowSeries { get; set; }

        public DbSet<TvShowToCountry> tvShowToCountries { get; set; }

        public DbSet<TvShowToCategory> tvShowToCategories { get; set; }

        public DbSet<Serial> serials { get; set; }

        public DbSet<SerialSeason> serialSeasons { get; set; }

        public DbSet<SerialSerie> serialSeries { get; set; }

        public DbSet<SerialToCategory> serialToCategories { get; set; }

        public DbSet<SerialToCountry> serialToCountries { get; set; }

        public DbSet<Film> films { get; set; }

        public DbSet<FilmToCategory> filmToCategories { get; set; }

        public DbSet<FilmToCountry> filmToCountries { get; set; }

        public DbSet<Platform> platforms { get; set; }

        public DbSet<Actor> actors { get; set; }

        public DbSet<FilmToActor> filmToActors { get; set; }

        public DbSet<SerialToActor> serialToActors { get; set; }

        public DbSet<TvShowToActor> tvShowToActors { get; set; }

        public DbSet<HomeSlider> homeSliders { get; set; }

        public DbSet<User> userProfils { get; set; }

        public DbSet<AboutUS> aboutUs { get; set; }

      

#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        public DbSet<User> Users { get; set; }
        #pragma warning restore CS0114 // Member hides inherited member; missing override keyword


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().ToTable("Users");
            builder.Entity<IdentityRole>().ToTable("Roles");
        }

        

    }
}
