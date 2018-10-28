namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChecklistStep")]
    public partial class ChecklistStep
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChecklistStep()
        {
            ChecklistPart = new HashSet<ChecklistPart>();
        }

        [Key]
        public int intChecklistStepID { get; set; }

        public int intChecklistIntervalID { get; set; }

        public int intIntervalID { get; set; }

        public int intStepNo { get; set; }

        public int intOriginalStepID { get; set; }

        public int? intActionId { get; set; }

        public int intlLaborHours { get; set; }

        [StringLength(255)]
        public string strTitle { get; set; }

        public string strInstructions { get; set; }

        public int? oldStepId { get; set; }

        public int intChecklistID { get; set; }

        public virtual Checklist Checklist { get; set; }

        public virtual ChecklistInterval ChecklistInterval { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChecklistPart> ChecklistPart { get; set; }

        public virtual TablesAction TablesAction { get; set; }
    }
}
