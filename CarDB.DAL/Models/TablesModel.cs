namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesModel")]
    public partial class TablesModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesModel()
        {
            Checklist = new HashSet<Checklist>();
            newEquipment = new HashSet<newEquipment>();
            PMChecklist = new HashSet<PMChecklist>();
            TablesComponentTypeModelReleased = new HashSet<TablesComponentTypeModelReleased>();
            TablesSNPrefix = new HashSet<TablesSNPrefix>();
            TrackComponent = new HashSet<TrackComponent>();
        }

        [Key]
        public int intModelID { get; set; }

        [StringLength(10)]
        public string strName { get; set; }

        public int? intManufacturerID { get; set; }

        public int? intSMCSFamilyID { get; set; }

        [StringLength(250)]
        public string strImage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Checklist> Checklist { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<newEquipment> newEquipment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMChecklist> PMChecklist { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TablesComponentTypeModelReleased> TablesComponentTypeModelReleased { get; set; }

        public virtual TablesManufacturer TablesManufacturer { get; set; }

        public virtual TablesSMCSFamily TablesSMCSFamily { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TablesSNPrefix> TablesSNPrefix { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackComponent> TrackComponent { get; set; }
    }
}
