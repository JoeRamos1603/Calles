//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Carreteras.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_roles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_roles()
        {
            this.tb_pantallasXroles = new HashSet<tb_pantallasXroles>();
            this.tb_usuariosXroles = new HashSet<tb_usuariosXroles>();
        }
    
        public string rol_id { get; set; }
        public string rol_descripcion { get; set; }
        public string rol_usuario_crea { get; set; }
        public Nullable<System.DateTime> rol_fecha_crea { get; set; }
        public string rol_usuario_modifica { get; set; }
        public Nullable<System.DateTime> rol_fecha_modifica { get; set; }
        public Nullable<bool> rol_estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_pantallasXroles> tb_pantallasXroles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuariosXroles> tb_usuariosXroles { get; set; }
        public virtual tb_usuarios tb_usuarios { get; set; }
        public virtual tb_usuarios tb_usuarios1 { get; set; }
    }
}
