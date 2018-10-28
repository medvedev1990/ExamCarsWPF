namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesSMCSJob")]
    public partial class TablesSMCSJob
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesSMCSJob()
        {
            TrackTechnicalWorkComponent = new HashSet<TrackTechnicalWorkComponent>();
        }

        [Key]
        public int intSMCSJob { get; set; }

        [StringLength(4)]
        public string strCode { get; set; }

        [StringLength(255)]
        public string strDescription { get; set; }

        [StringLength(255)]
        public string strDescriptionRu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackTechnicalWorkComponent> TrackTechnicalWorkComponent { get; set; }
    }
}
