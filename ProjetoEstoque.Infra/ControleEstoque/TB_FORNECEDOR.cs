namespace ProjetoEstoque.Infra.ControleEstoque
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_FORNECEDOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_FORNECEDOR()
        {
            TB_PRODUTO = new HashSet<TB_PRODUTO>();
            TB_PRODUTO1 = new HashSet<TB_PRODUTO>();
            TB_PRODUTO2 = new HashSet<TB_PRODUTO>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(60)]
        public string NOME { get; set; }

        [StringLength(100)]
        public string RAZAO_SOCIAL { get; set; }

        [StringLength(20)]
        public string NUM_DOCUMENTO { get; set; }

        public int TIPO { get; set; }

        [Required]
        [StringLength(20)]
        public string TELEFONE { get; set; }

        [Required]
        [StringLength(60)]
        public string CONTATO { get; set; }

        [Required]
        [StringLength(100)]
        public string LOGRADOURO { get; set; }

        [Required]
        [StringLength(20)]
        public string NUMERO { get; set; }

        [StringLength(100)]
        public string COMPLEMENTO { get; set; }

        [StringLength(10)]
        public string CEP { get; set; }

        public int ID_PAIS { get; set; }

        public int ID_MUNICIPIO { get; set; }

        public int ID_CIDADE { get; set; }

        public bool ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PRODUTO> TB_PRODUTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PRODUTO> TB_PRODUTO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PRODUTO> TB_PRODUTO2 { get; set; }
    }
}
