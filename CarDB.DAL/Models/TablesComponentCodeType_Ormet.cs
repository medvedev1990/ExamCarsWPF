namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TablesComponentCodeType_Ormet
    {
        public short? component_level { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string division { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string major_comp { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(12)]
        public string minor_comp { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(12)]
        public string basic_comp { get; set; }

        [StringLength(25)]
        public string description { get; set; }

        [StringLength(4)]
        public string SMCS_comp { get; set; }
    }
}
