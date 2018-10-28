namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesSimsCode")]
    public partial class TablesSimsCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesSimsCode()
        {
            TrackEvaluationSimsData = new HashSet<TrackEvaluationSimsData>();
        }

        [Key]
        public int intSimsCodeId { get; set; }

        [StringLength(550)]
        public string strSimsNameRu { get; set; }

        [StringLength(550)]
        public string strSimsNameEn { get; set; }

        public int? intSimsCode { get; set; }

        public int? intSimsType { get; set; }

        public virtual TablesSimsType TablesSimsType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackEvaluationSimsData> TrackEvaluationSimsData { get; set; }
    }
}
