namespace ProjetoEstoque.Infra.ControleEstoque
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_PERFIL_USUARIO
    {
        public int ID { get; set; }

        public int ID_PERFIL { get; set; }

        public int ID_USUARIO { get; set; }

        public virtual TB_PERFIL TB_PERFIL { get; set; }

        public virtual TB_PERFIL TB_PERFIL1 { get; set; }

        public virtual TB_USUARIO TB_USUARIO { get; set; }

        public virtual TB_USUARIO TB_USUARIO1 { get; set; }
    }
}
