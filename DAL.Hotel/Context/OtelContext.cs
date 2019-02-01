using DAL.Hotel.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Hotel.Context
{
    public class  OtelContext: DbContext
    {
        public OtelContext() : base("OtelContext")
        {
            //Migration işlemleri için DbContext (PIContext) ile Migration eşleştirilmelidir.
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<OtelContext, Configuration>("OtelContext"));
            this.Configuration.LazyLoadingEnabled = false; //İlişkili tablolara (Urunler gibi) sorgu çekmiyor, EagerLoading çalışıyor.
        }
        public virtual DbSet<Guest> Guests { get; set; }
        public virtual DbSet<Personnel> Personnel { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomType> RoomType { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<ExtraType> ExtraTypes { get; set; }
        public virtual DbSet<ExtraTransactions> ExtraTransactions { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
      

        protected override void OnModelCreating(DbModelBuilder modelBuilder)

        {

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        }
    }
}
