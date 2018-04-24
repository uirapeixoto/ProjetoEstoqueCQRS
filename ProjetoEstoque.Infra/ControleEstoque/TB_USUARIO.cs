namespace ProjetoEstoque.Infra.ControleEstoque
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_USUARIO()
        {
            TB_PERFIL_USUARIO = new HashSet<TB_PERFIL_USUARIO>();
            TB_PERFIL_USUARIO1 = new HashSet<TB_PERFIL_USUARIO>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string LOGIN { get; set; }

        [Required]
        [StringLength(32)]
        public string SENHA { get; set; }

        [Required]
        [StringLength(100)]
        public string NOME { get; set; }

        [Required]
        [StringLength(150)]
        public string EMAIL { get; set; }

        public int ID_PERFIL { get; set; }

        public virtual TB_PERFIL TB_PERFIL { get; set; }

        public virtual TB_PERFIL TB_PERFIL1 { get; set; }

        public virtual TB_PERFIL TB_PERFIL2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PERFIL_USUARIO> TB_PERFIL_USUARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PERFIL_USUARIO> TB_PERFIL_USUARIO1 { get; set; }
    }
}
