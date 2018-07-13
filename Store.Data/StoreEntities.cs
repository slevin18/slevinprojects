using Store.Data.Configuration;
using Store.Model;
using Store.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data
{
    // 
    /// <summary>
    /// Il DBContext è il modo per incorporare EntityFramework all'interno della nostra applicazione. La classe
    /// che deriva da esso è proprio il Data Access Layer.
    /// </summary>
    public class StoreEntities : DbContext
    {
        public StoreEntities() : base("StoreEntities") { }

        public DbSet<Gadget> Gadgets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Login> Login { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GadgetConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new LoginConfiguration());
        }
    }
}
