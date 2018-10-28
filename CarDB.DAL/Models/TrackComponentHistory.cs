namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrackComponentHistory")]
    public partial class TrackComponentHistory
    {
        [Key]
        public int intHistoryComponentId { get; set; }

        public int? intComponentId { get; set; }

        public int? intEquipmentID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dStartWork { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dEndWork { get; set; }

        public double? intMetered { get; set; }

        [StringLength(1024)]
        public string strComment { get; set; }

        public virtual newEquipment newEquipment { get; set; }

        public virtual TrackComponent TrackComponent { get; set; }
    }
}
