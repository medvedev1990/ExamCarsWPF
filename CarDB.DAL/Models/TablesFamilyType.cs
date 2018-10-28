namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesFamilyType")]
    public partial class TablesFamilyType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesFamilyType()
        {
            newEquipment = new HashSet<newEquipment>();
        }

        [Key]
        public int intFamilyTypeId { get; set; }

        public int? intEquipmentTypeId { get; set; }

        public int? intManufacturerID { get; set; }

        [Required]
        [StringLength(1024)]
        public string strFamilyName { get; set; }

        public int? intMajorFamilyID { get; set; }

        public int? intSMCSFamilyID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<newEquipment> newEquipment { get; set; }

        public virtual TablesManufacturer TablesManufacturer { get; set; }

        public virtual TablesSMCSFamily TablesSMCSFamily { get; set; }
    }
}
