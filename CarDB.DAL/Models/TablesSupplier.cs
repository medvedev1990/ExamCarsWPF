namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesSupplier")]
    public partial class TablesSupplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesSupplier()
        {
            TrackServiceHistoryProvider = new HashSet<TrackServiceHistoryProvider>();
        }

        [Key]
        public int intSupplierId { get; set; }

        [StringLength(30)]
        public string strSupplierName { get; set; }

        public double? intLaborRate { get; set; }

        [StringLength(12)]
        public string strCraft { get; set; }

        [StringLength(1)]
        public string strShift { get; set; }

        [StringLength(20)]
        public string strOther { get; set; }

        public int intLocationId { get; set; }

        public bool isRemove { get; set; }

        public int? intLaborRateCurrency { get; set; }

        public virtual TablesLocation TablesLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackServiceHistoryProvider> TrackServiceHistoryProvider { get; set; }
    }
}
