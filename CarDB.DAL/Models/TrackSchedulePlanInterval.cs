namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrackSchedulePlanInterval")]
    public partial class TrackSchedulePlanInterval
    {
        [Key]
        public int intSchedulePlanInterval { get; set; }

        public int? intSchedulePlanId { get; set; }

        public int? intScheduleId { get; set; }

        public int? intPMChecklistIntervalID { get; set; }

        public int? intIntervalNo { get; set; }

        [StringLength(50)]
        public string strInterval { get; set; }
    }
}
