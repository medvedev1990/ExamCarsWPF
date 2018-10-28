namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesAction")]
    public partial class TablesAction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesAction()
        {
            ChecklistStep = new HashSet<ChecklistStep>();
            PMChecklistStep = new HashSet<PMChecklistStep>();
        }

        [Key]
        public int intActionId { get; set; }

        [Required]
        [StringLength(30)]
        public string strAction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChecklistStep> ChecklistStep { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMChecklistStep> PMChecklistStep { get; set; }
    }
}
