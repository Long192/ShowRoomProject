//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vehicle_ShowRoom_Manager_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShowRoom
    {
        public int RoomId { get; set; }
        public string RoomAddress { get; set; }
        public string RoomName { get; set; }
        public Nullable<int> AdminId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> VehicleId { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
