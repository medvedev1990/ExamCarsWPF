namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesLocation")]
    public partial class TablesLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesLocation()
        {
            AccessUser = new HashSet<AccessUser>();
            newEquipment = new HashSet<newEquipment>();
            PMChecklist = new HashSet<PMChecklist>();
            TableEvaluationPriority = new HashSet<TableEvaluationPriority>();
            TablesEquipmentType = new HashSet<TablesEquipmentType>();
            TablesJobReason = new HashSet<TablesJobReason>();
            TablesMasterPart = new HashSet<TablesMasterPart>();
            TablesStopReason = new HashSet<TablesStopReason>();
            TablesSupplier = new HashSet<TablesSupplier>();
            TablesTypesInspection = new HashSet<TablesTypesInspection>();
            TrackComponent = new HashSet<TrackComponent>();
            TrackConsumable = new HashSet<TrackConsumable>();
            TrackEvaluation = new HashSet<TrackEvaluation>();
            TrackMeter = new HashSet<TrackMeter>();
            TrackSchedule = new HashSet<TrackSchedule>();
            TrackServiceHistory = new HashSet<TrackServiceHistory>();
            User = new HashSet<User>();
            UsersLocation = new HashSet<UsersLocation>();
        }

        [Key]
        public int intLocationId { get; set; }

        [StringLength(500)]
        public string strLocationName { get; set; }

        public int? intMajorLocationID { get; set; }

        public double? floatWageStatements { get; set; }

        public int? intWageStatementsCurrency { get; set; }

        public double? floatAdministrativeExpenses { get; set; }

        public int? intAdministrativeExpensesCurrency { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccessUser> AccessUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<newEquipment> newEquipment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMChecklist> PMChecklist { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TableEvaluationPriority> TableEvaluationPriority { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TablesEquipmentType> TablesEquipmentType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TablesJobReason> TablesJobReason { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TablesMasterPart> TablesMasterPart { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TablesStopReason> TablesStopReason { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TablesSupplier> TablesSupplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TablesTypesInspection> TablesTypesInspection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackComponent> TrackComponent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackConsumable> TrackConsumable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackEvaluation> TrackEvaluation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackMeter> TrackMeter { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackSchedule> TrackSchedule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackServiceHistory> TrackServiceHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersLocation> UsersLocation { get; set; }
    }
}
