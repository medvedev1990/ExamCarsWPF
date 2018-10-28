namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesMachineSystem")]
    public partial class TablesMachineSystem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablesMachineSystem()
        {
            TablesSmcsCodeMachineSystem = new HashSet<TablesSmcsCodeMachineSystem>();
            TrackEvaluation = new HashSet<TrackEvaluation>();
        }

        [Key]
        public int intMachineSystem { get; set; }

        [StringLength(250)]
        public string strMachineSystemNameRu { get; set; }

        [StringLength(250)]
        public string strMachineSystemName { get; set; }

        public bool bitInTopProblemReport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TablesSmcsCodeMachineSystem> TablesSmcsCodeMachineSystem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackEvaluation> TrackEvaluation { get; set; }
    }
}
