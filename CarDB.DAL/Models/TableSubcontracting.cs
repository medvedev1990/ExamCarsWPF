namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TableSubcontracting")]
    public partial class TableSubcontracting
    {
        [Key]
        public int intSubcontractingId { get; set; }

        public int? intEquipmentID { get; set; }

        [StringLength(250)]
        public string strManufacturer { get; set; }

        [StringLength(250)]
        public string strPartno { get; set; }

        [StringLength(250)]
        public string strPartDescription { get; set; }

        public double? fPartCost { get; set; }

        public double? fQuantity { get; set; }

        public double? fTotalCost { get; set; }

        public int? intCurrencyId { get; set; }

        public int? intYear { get; set; }

        public int? intPeriod { get; set; }

        public virtual newEquipment newEquipment { get; set; }

        public virtual TablesCurrency TablesCurrency { get; set; }
    }
}
