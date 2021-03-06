//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoreDA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Archivo_Investigacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Archivo_Investigacion()
        {
            this.Det_Archivo_Inv = new HashSet<Det_Archivo_Inv>();
            this.Descarga_ArchivoI = new HashSet<Descarga_ArchivoI>();
            this.Proyecto1 = new HashSet<Proyecto>();
        }
    
        public int ID_ArchivoI { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.DateTime> Fecha_invest { get; set; }
        public Nullable<System.DateTime> Fecha_pub_ini { get; set; }
        public Nullable<System.DateTime> Fecha_pub_fin { get; set; }
        public string Foto { get; set; }
        public Nullable<int> Estado { get; set; }
        public string Referencia { get; set; }
        public Nullable<System.DateTime> Fecha_crea { get; set; }
        public Nullable<int> ID_Usuario_crea { get; set; }
        public Nullable<System.DateTime> Fecha_mod { get; set; }
        public Nullable<int> ID_Usuario_mod { get; set; }
        public string Link_file { get; set; }
        public string Keywords { get; set; }
        public Nullable<int> ID_Proyecto { get; set; }
        public string AI_Externo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Det_Archivo_Inv> Det_Archivo_Inv { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Descarga_ArchivoI> Descarga_ArchivoI { get; set; }
        public virtual Proyecto Proyecto { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proyecto> Proyecto1 { get; set; }
    }
}
