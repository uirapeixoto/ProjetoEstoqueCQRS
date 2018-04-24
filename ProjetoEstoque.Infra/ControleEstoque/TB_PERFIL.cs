namespace ProjetoEstoque.Infra.ControleEstoque
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_PERFIL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_PERFIL()
        {
            TB_PERFIL_USUARIO = new HashSet<TB_PERFIL_USUARIO>();
            TB_PERFIL_USUARIO1 = new HashSet<TB_PERFIL_USUARIO>();
            TB_USUARIO = new HashSet<TB_USUARIO>();
            TB_USUARIO1 = new HashSet<TB_USUARIO>();
            TB_USUARIO2 = new HashSet<TB_USUARIO>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string NOME { get; set; }

        public bool ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PERFIL_USUARIO> TB_PERFIL_USUARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PERFIL_USUARIO> TB_PERFIL_USUARIO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_USUARIO> TB_USUARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_USUARIO> TB_USUARIO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_USUARIO> TB_USUARIO2 { get; set; }
    }
}
