namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChecklistInterval")]
    public partial class ChecklistInterval
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChecklistInterval()
        {
            ChecklistStep = new HashSet<ChecklistStep>();
        }

        [Key]
        public int intChecklistIntervalID { get; set; }

        public int intChecklistID { get; set; }

        public int intChecklistPartID { get; set; }

        public int intChecklistStepID { get; set; }

        [Required]
        [StringLength(512)]
        public string strChecklistID { get; set; }

        public int intIntervalNo { get; set; }

        [Required]
        [StringLength(20)]
        public string strInterval { get; set; }

        [StringLength(12)]
        public string strPMRepairJob { get; set; }

        public int intSummaryLaborHours { get; set; }

        public int intSummaryLaborCost { get; set; }

        public int intSummaryMaterialCost { get; set; }

        public virtual Checklist Checklist { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChecklistStep> ChecklistStep { get; set; }
    }
}
