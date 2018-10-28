namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesModifier")]
    public partial class TablesModifier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesModifier()
        {
            TrackComponent = new HashSet<TrackComponent>();
        }

        [Key]
        public int intModifierId { get; set; }

        [StringLength(4)]
        public string strModifierName { get; set; }

        public int? intSMCSModifierId { get; set; }

        [StringLength(25)]
        public string strDescription { get; set; }

        public virtual TablesSMCSModifier TablesSMCSModifier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackComponent> TrackComponent { get; set; }
    }
}
