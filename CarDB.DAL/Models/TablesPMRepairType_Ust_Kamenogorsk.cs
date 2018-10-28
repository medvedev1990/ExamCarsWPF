namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesPMRepairType_Ust-Kamenogorsk")]
    public partial class TablesPMRepairType_Ust_Kamenogorsk
    {
        [StringLength(10)]
        public string job { get; set; }

        [StringLength(12)]
        public string division { get; set; }

        [Key]
        public bool pm_type { get; set; }

        [StringLength(4)]
        public string SMCS { get; set; }

        [StringLength(25)]
        public string Description { get; set; }

        public short? pm_repair_level { get; set; }
    }
}
