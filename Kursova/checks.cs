//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kursova
{
    using System;
    using System.Collections.Generic;
    
    public partial class checks
    {
        public int check_id { get; set; }
        public int order_id { get; set; }
        public int details_id { get; set; }
    
        public virtual details details { get; set; }
        public virtual orders orders { get; set; }
    }
}
