namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesComponentType")]
    public partial class TablesComponentType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesComponentType()
        {
            TablesComponentTypeModelReleased = new HashSet<TablesComponentTypeModelReleased>();
            TablesComponentTypeSMCSInterval = new HashSet<TablesComponentTypeSMCSInterval>();
            TrackComponent = new HashSet<TrackComponent>();
        }

        [Key]
        public int intComponentTypeID { get; set; }

        [StringLength(255)]
        public string strComponentType { get; set; }

        [StringLength(500)]
        public string strDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TablesComponentTypeModelReleased> TablesComponentTypeModelReleased { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TablesComponentTypeSMCSInterval> TablesComponentTypeSMCSInterval { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackComponent> TrackComponent { get; set; }
    }
}
