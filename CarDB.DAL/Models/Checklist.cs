namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Checklist")]
    public partial class Checklist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Checklist()
        {
            ChecklistInterval = new HashSet<ChecklistInterval>();
            ChecklistStep = new HashSet<ChecklistStep>();
            PMChecklistAssign = new HashSet<PMChecklistAssign>();
        }

        [Key]
        public int intChecklistID { get; set; }

        [Required]
        [StringLength(250)]
        public string strChecklistID { get; set; }

        public int intChecklistType { get; set; }

        [StringLength(36)]
        public string strParentChecklistID { get; set; }

        [StringLength(255)]
        public string strDescription { get; set; }

        public int? intEquipmentType { get; set; }

        public bool bPMChecklist { get; set; }

        public int? intManufacturer { get; set; }

        public int? intSMCSFamilyID { get; set; }

        public int? intModelID { get; set; }

        public int? intSNPrefixID { get; set; }

        public int? intSNRangeID { get; set; }

        [StringLength(25)]
        public string strSource { get; set; }

        [StringLength(25)]
        public string strLanguage { get; set; }

        [StringLength(40)]
        public string strCustomer { get; set; }

        [StringLength(50)]
        public string strContractNo { get; set; }

        [StringLength(12)]
        public string strComponentCode { get; set; }

        [StringLength(8)]
        public string strModifier { get; set; }

        [StringLength(2)]
        public string strQuantity { get; set; }

        [StringLength(25)]
        public string strOperatorsManual { get; set; }

        [StringLength(25)]
        public string strPartsManual { get; set; }

        [StringLength(50)]
        public string strDefaultSupplier { get; set; }

        [Column(TypeName = "date")]
        public DateTime dateCreated { get; set; }

        [Column(TypeName = "date")]
        public DateTime dateLastUpdated { get; set; }

        public bool bUseCalculatedCosts { get; set; }

        public bool bIncludeOptionalParts { get; set; }

        [StringLength(1024)]
        public string strFilePath { get; set; }

        public virtual TablesEquipmentType TablesEquipmentType { get; set; }

        public virtual TablesManufacturer TablesManufacturer { get; set; }

        public virtual TablesModel TablesModel { get; set; }

        public virtual TablesSMCSFamily TablesSMCSFamily { get; set; }

        public virtual TablesSNPrefix TablesSNPrefix { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChecklistInterval> ChecklistInterval { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChecklistStep> ChecklistStep { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMChecklistAssign> PMChecklistAssign { get; set; }
    }
}
