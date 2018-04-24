namespace ProjetoEstoque.Infra.Public
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Municipios
    {
        public int Id { get; set; }

        public int CodigoIBGE { get; set; }

        [Required]
        [StringLength(100)]
        public string Municipio { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public int Estado_Id { get; set; }

        public virtual Estados Estados { get; set; }
    }
}
