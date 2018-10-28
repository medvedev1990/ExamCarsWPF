namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PMChecklistStep")]
    public partial class PMChecklistStep
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PMChecklistStep()
        {
            PMChecklistPart = new HashSet<PMChecklistPart>();
        }

        [Key]
        public int intPMChecklistStepID { get; set; }

        public int intPMChecklistIntervalID { get; set; }

        public int intStepNo { get; set; }

        public int intOriginalStepID { get; set; }

        public int? intActionId { get; set; }

        public int intlLaborHours { get; set; }

        [StringLength(60)]
        public string strTitle { get; set; }

        public string strInstructions { get; set; }

        public int? oldStepId { get; set; }

        public int? intPMChecklistID { get; set; }

        public virtual PMChecklistInterval PMChecklistInterval { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMChecklistPart> PMChecklistPart { get; set; }

        public virtual TablesAction TablesAction { get; set; }
    }
}
