namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesMasterPart")]
    public partial class TablesMasterPart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesMasterPart()
        {
            PMChecklistPart = new HashSet<PMChecklistPart>();
            TrackEvaluationPart = new HashSet<TrackEvaluationPart>();
            TrackServiceHistoryPart = new HashSet<TrackServiceHistoryPart>();
        }

        [Key]
        public int intMasterPartId { get; set; }

        [StringLength(20)]
        public string strPartno { get; set; }

        [StringLength(25)]
        public string strPartDescription { get; set; }

        [StringLength(30)]
        public string strObtainFrom { get; set; }

        public double intPartCost { get; set; }

        public double? AkPrice { get; set; }

        public double? TkPrice { get; set; }

        public double? intOnOrder { get; set; }

        public DateTime? dOrderDate { get; set; }

        public DateTime? dArrivalDate { get; set; }

        public DateTime? LastChange { get; set; }

        public int? ChangeUserId { get; set; }

        [StringLength(3500)]
        public string strChangeDescription { get; set; }

        public int? intLocationId { get; set; }

        public int? intCurrencyId { get; set; }

        public virtual ChecklistPart ChecklistPart { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMChecklistPart> PMChecklistPart { get; set; }

        public virtual TablesCurrency TablesCurrency { get; set; }

        public virtual TablesLocation TablesLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackEvaluationPart> TrackEvaluationPart { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackServiceHistoryPart> TrackServiceHistoryPart { get; set; }
    }
}
