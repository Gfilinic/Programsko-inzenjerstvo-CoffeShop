﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PI_2021_Kafic
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Artikl> Artikl { get; set; }
        public virtual DbSet<Kafic> Kafic { get; set; }
        public virtual DbSet<Kategorija> Kategorija { get; set; }
        public virtual DbSet<Konobar> Konobar { get; set; }
        public virtual DbSet<Moderator> Moderator { get; set; }
        public virtual DbSet<Nacin_Placanja> Nacin_Placanja { get; set; }
        public virtual DbSet<Namirnica> Namirnica { get; set; }
        public virtual DbSet<Normativ> Normativ { get; set; }
        public virtual DbSet<Poduzeće> Poduzeće { get; set; }
        public virtual DbSet<Racun> Racun { get; set; }
        public virtual DbSet<Skladiste> Skladiste { get; set; }
        public virtual DbSet<Stavka_normativa> Stavka_normativa { get; set; }
        public virtual DbSet<Stavka_racuna> Stavka_racuna { get; set; }
        public virtual DbSet<Stol> Stol { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
