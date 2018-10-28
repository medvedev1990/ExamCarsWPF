namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrackConsumable")]
    public partial class TrackConsumable
    {
        [Key]
        public int intConsumableId { get; set; }

        public int? intEquipmentID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dConsumableDate { get; set; }

        public int? intTypeConsumableId { get; set; }

        public int? intSegNo { get; set; }

        public double? intCost { get; set; }

        public double? intExtendedCost { get; set; }

        public double? intQuantity { get; set; }

        public bool boolSummary { get; set; }

        public double? intConsumableMeter { get; set; }

        public int? intLocationId { get; set; }

        public int? intCostCurrency { get; set; }

        public virtual newEquipment newEquipment { get; set; }

        public virtual TablesConsumable TablesConsumable { get; set; }

        public virtual TablesLocation TablesLocation { get; set; }
    }
}
