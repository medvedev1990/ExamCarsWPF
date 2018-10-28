namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesEquipmentType")]
    public partial class TablesEquipmentType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesEquipmentType()
        {
            Checklist = new HashSet<Checklist>();
            newEquipment = new HashSet<newEquipment>();
            PMChecklist = new HashSet<PMChecklist>();
        }

        [Key]
        public int intEquipmentTypeId { get; set; }

        [StringLength(255)]
        public string strUnits { get; set; }

        [StringLength(255)]
        public string strDivision { get; set; }

        public double? intDecimal { get; set; }

        public int intLocationId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Checklist> Checklist { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<newEquipment> newEquipment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMChecklist> PMChecklist { get; set; }

        public virtual TablesLocation TablesLocation { get; set; }
    }
}
