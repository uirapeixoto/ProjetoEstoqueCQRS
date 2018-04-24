namespace ProjetoEstoque.Infra.ControleEstoque
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_MARCA_PRODUTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_MARCA_PRODUTO()
        {
            TB_PRODUTO = new HashSet<TB_PRODUTO>();
            TB_PRODUTO1 = new HashSet<TB_PRODUTO>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string NOME { get; set; }

        public bool ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PRODUTO> TB_PRODUTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PRODUTO> TB_PRODUTO1 { get; set; }
    }
}
