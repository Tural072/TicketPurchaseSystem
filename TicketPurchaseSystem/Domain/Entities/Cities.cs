//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketPurchaseSystem.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cities
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cities()
        {
            this.Tickets = new HashSet<Tickets>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> AirplaneId { get; set; }
        public Nullable<int> ScheludeId { get; set; }
    
        public virtual Airplanes Airplanes { get; set; }
        public virtual Schedules Schedules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}