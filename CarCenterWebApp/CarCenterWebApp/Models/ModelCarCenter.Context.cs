﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarCenterWebApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class carcenterEntities : DbContext
    {
        public carcenterEntities()
            : base("name=carcenterEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CITAS> CITAS { get; set; }
        public virtual DbSet<DOMINIOS> DOMINIOS { get; set; }
        public virtual DbSet<FACTURAS> FACTURAS { get; set; }
        public virtual DbSet<FOTOS> FOTOS { get; set; }
        public virtual DbSet<MENSAJES> MENSAJES { get; set; }
        public virtual DbSet<PERSONA_VEHICULO> PERSONA_VEHICULO { get; set; }
        public virtual DbSet<PERSONAS> PERSONAS { get; set; }
        public virtual DbSet<REPUESTOS> REPUESTOS { get; set; }
        public virtual DbSet<SERVICIO_REPUESTO> SERVICIO_REPUESTO { get; set; }
        public virtual DbSet<SERVICIOS> SERVICIOS { get; set; }
        public virtual DbSet<VEHICULOS> VEHICULOS { get; set; }
    }
}