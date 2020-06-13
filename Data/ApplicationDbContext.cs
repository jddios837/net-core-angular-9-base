using Microsoft.EntityFrameworkCore;
using WorldCities.Data.Models;

namespace WorldCities
{
    public class ApplicationDbContext : DbContext
    {
        #region Constructor
        public ApplicationDbContext() : base()
        {
        }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }   
        #endregion Constructor

        #region Methods
        protected override void OnModelCreating (ModelBuilder modelbuilder) 
        { 
            base.OnModelCreating(modelbuilder);

            //Map Entity names to DB Table name
            modelbuilder.Entity<City>().ToTable("Cities");
            modelbuilder.Entity<Country>().ToTable("Countries");
        }
        #endregion Methods

        #region Properties
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        #endregion Properties
    }
}