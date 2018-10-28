namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesJobReason")]
    public partial class TablesJobReason
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesJobReason()
        {
            TrackSchedulePlan = new HashSet<TrackSchedulePlan>();
            TrackServiceHistory = new HashSet<TrackServiceHistory>();
        }

        [Key]
        public int intJobReasonId { get; set; }

        [StringLength(255)]
        public string strReason { get; set; }

        public int intLocationId { get; set; }

        public virtual TablesLocation TablesLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackSchedulePlan> TrackSchedulePlan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackServiceHistory> TrackServiceHistory { get; set; }
    }
}
