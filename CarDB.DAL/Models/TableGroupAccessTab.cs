namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TableGroupAccessTab")]
    public partial class TableGroupAccessTab
    {
        [Key]
        public int intGroupAccessTabId { get; set; }

        public int? intGroupAccessId { get; set; }

        public int? intTabID { get; set; }

        public virtual AccessTab AccessTab { get; set; }

        public virtual TableGroupAccess TableGroupAccess { get; set; }
    }
}
