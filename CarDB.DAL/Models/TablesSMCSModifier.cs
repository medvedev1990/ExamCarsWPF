namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesSMCSModifier")]
    public partial class TablesSMCSModifier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesSMCSModifier()
        {
            TablesModifier = new HashSet<TablesModifier>();
        }

        [Key]
        public int intSMCSModifierId { get; set; }

        [StringLength(4)]
        public string strCode { get; set; }

        [StringLength(25)]
        public string strDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TablesModifier> TablesModifier { get; set; }
    }
}
