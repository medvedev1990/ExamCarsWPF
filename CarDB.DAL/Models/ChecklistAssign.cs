namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChecklistAssign")]
    public partial class ChecklistAssign
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string strEquipmentID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(36)]
        public string strChecklistID { get; set; }
    }
}
