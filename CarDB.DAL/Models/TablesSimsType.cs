namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesSimsType")]
    public partial class TablesSimsType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesSimsType()
        {
            TablesSimsCode = new HashSet<TablesSimsCode>();
        }

        [Key]
        public int intSimsType { get; set; }

        [StringLength(200)]
        public string strName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TablesSimsCode> TablesSimsCode { get; set; }
    }
}
