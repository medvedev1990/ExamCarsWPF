namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesComponentTypeModelReleased")]
    public partial class TablesComponentTypeModelReleased
    {
        [Key]
        public int intModelReleasedId { get; set; }

        public int? intComponentTypeID { get; set; }

        public int? intModelID { get; set; }

        [StringLength(512)]
        public string strDescription { get; set; }

        public virtual TablesComponentType TablesComponentType { get; set; }

        public virtual TablesModel TablesModel { get; set; }
    }
}
