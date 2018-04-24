namespace ProjetoEstoque.Infra.ControleEstoque
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_UNIDADE_MEDIDA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_UNIDADE_MEDIDA()
        {
            TB_PRODUTO = new HashSet<TB_PRODUTO>();
            TB_PRODUTO1 = new HashSet<TB_PRODUTO>();
            TB_PRODUTO2 = new HashSet<TB_PRODUTO>();
            TB_PRODUTO3 = new HashSet<TB_PRODUTO>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string NOME { get; set; }

        [Required]
        [StringLength(3)]
        public string SIGLA { get; set; }

        public bool ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PRODUTO> TB_PRODUTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PRODUTO> TB_PRODUTO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PRODUTO> TB_PRODUTO2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PRODUTO> TB_PRODUTO3 { get; set; }
    }
}
