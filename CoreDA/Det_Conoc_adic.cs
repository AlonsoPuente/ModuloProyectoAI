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
    
    public partial class Det_Conoc_adic
    {
        public int ID_HojaVida { get; set; }
        public string Tipo { get; set; }
        public string Herramienta { get; set; }
        public string Nivel { get; set; }
    
        public virtual Hoja_Vida Hoja_Vida { get; set; }
    }
}
