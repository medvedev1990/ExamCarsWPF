namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesComponentTypeSMCSInterval")]
    public partial class TablesComponentTypeSMCSInterval
    {
        [Key]
        public int intSMCSIntervalComponentId { get; set; }

        public int? intComponentTypeID { get; set; }

        [StringLength(4)]
        public string intStart { get; set; }

        [StringLength(4)]
        public string intEnd { get; set; }

        [StringLength(512)]
        public string strDescription { get; set; }

        public virtual TablesComponentType TablesComponentType { get; set; }
    }
}
