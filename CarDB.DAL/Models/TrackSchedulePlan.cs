namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrackSchedulePlan")]
    public partial class TrackSchedulePlan
    {
        [Key]
        public int intSchedulePlanId { get; set; }

        public int? intScheduleId { get; set; }

        public int? intStopReason { get; set; }

        public DateTime dScheduleDate { get; set; }

        public DateTime? dScheduleEndDate { get; set; }

        public double? fMetered { get; set; }

        [StringLength(255)]
        public string strDescriptionProblem { get; set; }

        public int? intJobReasonId { get; set; }

        public double? intlLaborHours { get; set; }

        [StringLength(255)]
        public string strDescriptiontFindings { get; set; }

        public int? intPMChecklistIntervalID { get; set; }

        [StringLength(550)]
        public string strListChecklistInterval { get; set; }

        public int? intSMCSJob { get; set; }

        public int? intComponentId { get; set; }

        public int? intModifierId { get; set; }

        public int? intQuantityId { get; set; }

        public int? intStatusSchedule { get; set; }

        [StringLength(50)]
        public string strSchedulePlanColor { get; set; }

        public int? intLocationId { get; set; }

        public virtual TablesJobReason TablesJobReason { get; set; }

        public virtual TablesStopReason TablesStopReason { get; set; }

        public virtual TrackSchedule TrackSchedule { get; set; }
    }
}
