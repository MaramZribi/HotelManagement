﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hotelManagementSystem20.models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HotelManagementSystemEntities4 : DbContext
    {
        public HotelManagementSystemEntities4()
            : base("name=HotelManagementSystemEntities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<client> client { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }
        public virtual DbSet<room> room { get; set; }
        public virtual DbSet<users> users { get; set; }
    }
}
