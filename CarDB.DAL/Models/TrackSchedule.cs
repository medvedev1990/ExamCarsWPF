namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrackSchedule")]
    public partial class TrackSchedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TrackSchedule()
        {
            TrackSchedulePlan = new HashSet<TrackSchedulePlan>();
        }

        [Key]
        public int intScheduleId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dStartSchedule { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dEndSchedule { get; set; }

        public int? intPmChecklist { get; set; }

        public int? intEquipmentID { get; set; }

        public int? intLocationId { get; set; }

        public double? fBaceMetered { get; set; }

        public double? fMetered { get; set; }

        public int? intStatus { get; set; }

        public virtual newEquipment newEquipment { get; set; }

        public virtual PMChecklist PMChecklist { get; set; }

        public virtual TablesLocation TablesLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackSchedulePlan> TrackSchedulePlan { get; set; }
    }
}
