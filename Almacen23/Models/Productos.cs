//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Almacen23.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            this.Despacho = new HashSet<Despacho>();
        }
    
        public int Id { get; set; }
        [Required]
        public System.DateTime Fecha_de_Vencimiento { get; set; }
        [Required]
        public System.DateTime Fecha_de_creacion { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
            [Required]
            public string UDM { get; set; }
        [Required]
        public decimal Costo { get; set; }
        [Required]
        public string Existencia { get; set; }
        [Required]
        public string Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Despacho> Despacho { get; set; }
    }
}
