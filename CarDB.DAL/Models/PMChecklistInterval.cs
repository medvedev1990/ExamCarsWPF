namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PMChecklistInterval")]
    public partial class PMChecklistInterval
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PMChecklistInterval()
        {
            PMChecklistStep = new HashSet<PMChecklistStep>();
        }

        [Key]
        public int intPMChecklistIntervalID { get; set; }

        public int intPMChecklistID { get; set; }

        public int intIntervalNo { get; set; }

        [Required]
        [StringLength(20)]
        public string strInterval { get; set; }

        [StringLength(12)]
        public string strPMRepairJob { get; set; }

        public int intSummaryLaborHours { get; set; }

        public int intSummaryLaborCost { get; set; }

        public int intSummaryMaterialCost { get; set; }

        public virtual PMChecklist PMChecklist { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMChecklistStep> PMChecklistStep { get; set; }
    }
}
