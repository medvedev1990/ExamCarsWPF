namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesStopReason")]
    public partial class TablesStopReason
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesStopReason()
        {
            TrackSchedulePlan = new HashSet<TrackSchedulePlan>();
            TrackServiceHistory = new HashSet<TrackServiceHistory>();
        }

        [Key]
        public int intStopReason { get; set; }

        [StringLength(255)]
        public string strReason { get; set; }

        public bool bitDowntime { get; set; }

        public bool bitUnscheduled { get; set; }

        public bool bitPMStoppages { get; set; }

        public bool bitScheduledRepairsAndOther { get; set; }

        public int intLocationId { get; set; }

        public virtual TablesLocation TablesLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackSchedulePlan> TrackSchedulePlan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackServiceHistory> TrackServiceHistory { get; set; }
    }
}
