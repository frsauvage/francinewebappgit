namespace GitWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COCKPIT_VALEUR
    {
        [Key]
        public int CVA_IDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CVA_VALEUR { get; set; }

        public int? CVA_DATE { get; set; }

        public int? CVA_TYPE_VALEUR { get; set; }

        public int? CVA_CATEGORIE { get; set; }

        public int? CVA_INDICATEUR { get; set; }

        public int? CVA_DECOUPAGE { get; set; }

        public int? CVA_REF_CDP { get; set; }

        public int? CVA_REF_GNC { get; set; }

        public int? CVA_REF_MCP { get; set; }

        public int? CVA_MOMENT { get; set; }
    }
}
