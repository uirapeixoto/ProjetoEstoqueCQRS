namespace ProjetoEstoque.Infra.ControleEstoque
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_PRODUTO
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string CODIGO { get; set; }

        [Required]
        [StringLength(50)]
        public string NOME { get; set; }

        public decimal PRECO_CUSTO { get; set; }

        public decimal PRECO_VENDA { get; set; }

        public int QUANT_ESTOQUE { get; set; }

        public int ID_UNIDADE_MEDIDA { get; set; }

        public int ID_GRUPO { get; set; }

        public int ID_MARCA { get; set; }

        public int ID_FORNECEDOR { get; set; }

        public int ID_LOCAL_ARMAZENAMENTO { get; set; }

        public bool ATIVO { get; set; }

        public virtual TB_FORNECEDOR TB_FORNECEDOR { get; set; }

        public virtual TB_FORNECEDOR TB_FORNECEDOR1 { get; set; }

        public virtual TB_FORNECEDOR TB_FORNECEDOR2 { get; set; }

        public virtual TB_GRUPO_PRODUTO TB_GRUPO_PRODUTO { get; set; }

        public virtual TB_GRUPO_PRODUTO TB_GRUPO_PRODUTO1 { get; set; }

        public virtual TB_LOCAL_ARMAZENAMENTO TB_LOCAL_ARMAZENAMENTO { get; set; }

        public virtual TB_MARCA_PRODUTO TB_MARCA_PRODUTO { get; set; }

        public virtual TB_MARCA_PRODUTO TB_MARCA_PRODUTO1 { get; set; }

        public virtual TB_UNIDADE_MEDIDA TB_UNIDADE_MEDIDA { get; set; }

        public virtual TB_UNIDADE_MEDIDA TB_UNIDADE_MEDIDA1 { get; set; }

        public virtual TB_UNIDADE_MEDIDA TB_UNIDADE_MEDIDA2 { get; set; }

        public virtual TB_UNIDADE_MEDIDA TB_UNIDADE_MEDIDA3 { get; set; }
    }
}
