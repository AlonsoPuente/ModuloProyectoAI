﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoreDA
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WebEntities2 : DbContext
    {
        public WebEntities2()
            : base("name=WebEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Archivo_Investigacion> Archivo_Investigacion { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Clic> Clic { get; set; }
        public virtual DbSet<Comentario> Comentario { get; set; }
        public virtual DbSet<Conoc_adic> Conoc_adic { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Descarga_ArchivoI> Descarga_ArchivoI { get; set; }
        public virtual DbSet<Det_Archivo_Inv> Det_Archivo_Inv { get; set; }
        public virtual DbSet<Det_Certificado> Det_Certificado { get; set; }
        public virtual DbSet<Det_Conoc_adic> Det_Conoc_adic { get; set; }
        public virtual DbSet<Det_Exp_Laboral> Det_Exp_Laboral { get; set; }
        public virtual DbSet<Det_Form_Acad> Det_Form_Acad { get; set; }
        public virtual DbSet<Det_Idiomas> Det_Idiomas { get; set; }
        public virtual DbSet<Det_Logro> Det_Logro { get; set; }
        public virtual DbSet<Det_Partic_Proyecto> Det_Partic_Proyecto { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Evento> Evento { get; set; }
        public virtual DbSet<Historial_Hoja_Vida> Historial_Hoja_Vida { get; set; }
        public virtual DbSet<Hoja_Vida> Hoja_Vida { get; set; }
        public virtual DbSet<Invitado> Invitado { get; set; }
        public virtual DbSet<Noticia> Noticia { get; set; }
        public virtual DbSet<Participantes> Participantes { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
        public virtual DbSet<Proyecto> Proyecto { get; set; }
        public virtual DbSet<Proyecto_Constr> Proyecto_Constr { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
