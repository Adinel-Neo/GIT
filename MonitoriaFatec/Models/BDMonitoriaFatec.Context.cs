﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MONITORIA_FATECEntities : DbContext
    {
        public MONITORIA_FATECEntities()
            : base("name=MONITORIA_FATECEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CONTENT> CONTENT { get; set; }
        public virtual DbSet<COURSE> COURSE { get; set; }
        public virtual DbSet<DISCIPLINE> DISCIPLINE { get; set; }
        public virtual DbSet<SCOPE> SCOPE { get; set; }
        public virtual DbSet<STATUSCONTENT> STATUSCONTENT { get; set; }
        public virtual DbSet<TYPECONTENT> TYPECONTENT { get; set; }
        public virtual DbSet<TYPEMESSAGE> TYPEMESSAGE { get; set; }
        public virtual DbSet<USERMESSAGE> USERMESSAGE { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
        public virtual DbSet<SCHEDULE> SCHEDULE { get; set; }
        public virtual DbSet<CALENDAR> CALENDAR { get; set; }
    }
}