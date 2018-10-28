namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesConsumable")]
    public partial class TablesConsumable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesConsumable()
        {
            TrackConsumable = new HashSet<TrackConsumable>();
        }

        [Key]
        public int intConsumableId { get; set; }

        [StringLength(13)]
        public string strName { get; set; }

        [StringLength(50)]
        public string strCode { get; set; }

        [StringLength(7)]
        public string strUnit { get; set; }

        public double? intCost { get; set; }

        public int? intCostCurrency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackConsumable> TrackConsumable { get; set; }
    }
}
