namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TableGroupAccess")]
    public partial class TableGroupAccess
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TableGroupAccess()
        {
            AccessUser = new HashSet<AccessUser>();
            TableGroupAccessTab = new HashSet<TableGroupAccessTab>();
        }

        [Key]
        public int intGroupAccessId { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccessUser> AccessUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TableGroupAccessTab> TableGroupAccessTab { get; set; }
    }
}
