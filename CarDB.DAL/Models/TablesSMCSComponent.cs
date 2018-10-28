namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesSMCSComponent")]
    public partial class TablesSMCSComponent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesSMCSComponent()
        {
            TablesSmcsCodeMachineSystem = new HashSet<TablesSmcsCodeMachineSystem>();
            TrackEvaluation = new HashSet<TrackEvaluation>();
            TrackComponent = new HashSet<TrackComponent>();
            TrackServiceHistory = new HashSet<TrackServiceHistory>();
            TrackTechnicalWorkComponent = new HashSet<TrackTechnicalWorkComponent>();
        }

        [Key]
        public int intSMCSComponentID { get; set; }

        [StringLength(4)]
        public string code { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string descriptionRu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TablesSmcsCodeMachineSystem> TablesSmcsCodeMachineSystem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackEvaluation> TrackEvaluation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackComponent> TrackComponent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackServiceHistory> TrackServiceHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackTechnicalWorkComponent> TrackTechnicalWorkComponent { get; set; }
    }
}
