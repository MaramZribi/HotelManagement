//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        public int Reservation_Id { get; set; }
        public int client_id { get; set; }
        public int room_id { get; set; }
        public System.DateTime DateDepart { get; set; }
        public System.DateTime DateArrivee { get; set; }
        public System.DateTime DateReservation { get; set; }
        public int nombreChambres { get; set; }
        public decimal prixTotale { get; set; }
    
        public virtual client client { get; set; }
        public virtual room room { get; set; }
    }
}