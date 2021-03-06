namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChecklistPart")]
    public partial class ChecklistPart
    {
        [Key]
        public int intChecklistPartID { get; set; }

        public int intChecklistStepID { get; set; }

        [StringLength(20)]
        public string strPartNo { get; set; }

        public int intQuantity { get; set; }

        public int? intlExtendedCost { get; set; }

        public bool? bitOptional { get; set; }

        public int? intOriginalPartID { get; set; }

        [StringLength(550)]
        public string strPartDescription { get; set; }

        public int intMasterPartId { get; set; }

        public virtual ChecklistStep ChecklistStep { get; set; }

        public virtual TablesMasterPart TablesMasterPart { get; set; }
    }
}
