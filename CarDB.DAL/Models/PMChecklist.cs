namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PMChecklist")]
    public partial class PMChecklist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PMChecklist()
        {
            PMChecklistInterval = new HashSet<PMChecklistInterval>();
            TrackSchedule = new HashSet<TrackSchedule>();
        }

        [Key]
        public int intPMChecklistID { get; set; }

        public int intPMChecklistAssignID { get; set; }

        [Required]
        [StringLength(36)]
        public string strChecklistName { get; set; }

        [StringLength(255)]
        public string strDescription { get; set; }

        public int? intEquipmentType { get; set; }

        public int? intManufacturer { get; set; }

        public int? intSMCSFamilyID { get; set; }

        public int? intModelID { get; set; }

        public int? intSNPrefixID { get; set; }

        [StringLength(40)]
        public string strCustomer { get; set; }

        [Column(TypeName = "date")]
        public DateTime dateCreated { get; set; }

        public int? intLocationId { get; set; }

        public virtual TablesEquipmentType TablesEquipmentType { get; set; }

        public virtual TablesLocation TablesLocation { get; set; }

        public virtual TablesManufacturer TablesManufacturer { get; set; }

        public virtual TablesModel TablesModel { get; set; }

        public virtual TablesSMCSFamily TablesSMCSFamily { get; set; }

        public virtual TablesSNPrefix TablesSNPrefix { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMChecklistInterval> PMChecklistInterval { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackSchedule> TrackSchedule { get; set; }
    }
}
