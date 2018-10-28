namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesSNPrefix")]
    public partial class TablesSNPrefix
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesSNPrefix()
        {
            Checklist = new HashSet<Checklist>();
            newEquipment = new HashSet<newEquipment>();
            PMChecklist = new HashSet<PMChecklist>();
        }

        [Key]
        public int intSNPrefixID { get; set; }

        [StringLength(5)]
        public string strPrefix { get; set; }

        public int? intModelID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Checklist> Checklist { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<newEquipment> newEquipment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMChecklist> PMChecklist { get; set; }

        public virtual TablesModel TablesModel { get; set; }
    }
}
