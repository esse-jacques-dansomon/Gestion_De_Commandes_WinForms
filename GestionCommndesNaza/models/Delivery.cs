//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionCommndesNaza.models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Delivery
    {
        public int Id { get; set; }
        public int DeliverId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Deliver Deliver { get; set; }
        public virtual Order Order { get; set; }
    }
}