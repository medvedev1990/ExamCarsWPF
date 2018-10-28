namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesTypesInspection")]
    public partial class TablesTypesInspection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesTypesInspection()
        {
            TrackEvaluation = new HashSet<TrackEvaluation>();
        }

        [Key]
        public int intTypeOfInspection { get; set; }

        [StringLength(250)]
        public string strNameInspection { get; set; }

        public int? intLocationId { get; set; }

        public virtual TablesLocation TablesLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackEvaluation> TrackEvaluation { get; set; }
    }
}
