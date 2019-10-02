using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Oblig1Nyere.Models
{
    public class DB : DbContext
    {
        public DB() : base("name=DB")    //Så står det igjen å spesifisere hvor vi vil legge databasen (spesifisere connection-string). Dette gjøres i konstruktøren til DB-klassen slik:
        {                               // Videre en litt spesiell «dekoratør» kalt base. I denne skal navnet til «connection-strengen» oppgis
            Database.CreateIfNotExists();
            Database.SetInitializer(new DBInit());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public virtual DbSet<Reise> Reise { get; set; }
        public virtual DbSet<Billett> Billetter { get; set; }



    }
}