namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesSMCSQuantity")]
    public partial class TablesSMCSQuantity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesSMCSQuantity()
        {
            TablesQuantity = new HashSet<TablesQuantity>();
        }

        [Key]
        public int intSMCSQuantityId { get; set; }

        [StringLength(2)]
        public string strCode { get; set; }

        [StringLength(25)]
        public string strDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TablesQuantity> TablesQuantity { get; set; }
    }
}
