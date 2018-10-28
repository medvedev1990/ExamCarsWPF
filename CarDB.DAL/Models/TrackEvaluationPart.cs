namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrackEvaluationPart")]
    public partial class TrackEvaluationPart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TrackEvaluationPart()
        {
            TrackEvaluationSimsData = new HashSet<TrackEvaluationSimsData>();
        }

        [Key]
        public int intEvaluationPartId { get; set; }

        public int? intEvalutionId { get; set; }

        public int intMasterPartId { get; set; }

        public double? floatQuantity { get; set; }

        public double? floatUnitCostTrack { get; set; }

        public double? floatUnitCostAvia { get; set; }

        [StringLength(50)]
        public string strAvailability { get; set; }

        [StringLength(2500)]
        public string strDescription { get; set; }

        public int? intPartStatus { get; set; }

        public int? intSimsId { get; set; }

        public virtual TablesMasterPart TablesMasterPart { get; set; }

        public virtual TrackEvaluation TrackEvaluation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackEvaluationSimsData> TrackEvaluationSimsData { get; set; }
    }
}
