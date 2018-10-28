namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PMChecklistAssign")]
    public partial class PMChecklistAssign
    {
        [Key]
        public int intPMChecklistAssignID { get; set; }

        public int intChecklistID { get; set; }

        public int? intPMChecklistID { get; set; }

        public virtual Checklist Checklist { get; set; }
    }
}
