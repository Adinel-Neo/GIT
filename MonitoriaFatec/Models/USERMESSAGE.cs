//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonitoriaFatec.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class USERMESSAGE
    {
        public int IDMESSAGE { get; set; }
        public int IDAUTHOR { get; set; }
        public int IDRECIVER { get; set; }
        public string HEADER { get; set; }
        public string BODY { get; set; }
        public System.DateTime MESSAGEDATE { get; set; }
        public Nullable<int> IDORIGINMESSAGE { get; set; }
        public int IDTYPEMESSAGE { get; set; }
    
        public virtual TYPEMESSAGE TYPEMESSAGE { get; set; }
    }
}