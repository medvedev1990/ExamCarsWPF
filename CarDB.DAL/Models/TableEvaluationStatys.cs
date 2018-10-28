namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TableEvaluationStatys
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TableEvaluationStatys()
        {
            TrackEvaluation = new HashSet<TrackEvaluation>();
        }

        [Key]
        public int intStatysId { get; set; }

        [StringLength(250)]
        public string strStatysName { get; set; }

        public int? intLocationId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackEvaluation> TrackEvaluation { get; set; }
    }
}
