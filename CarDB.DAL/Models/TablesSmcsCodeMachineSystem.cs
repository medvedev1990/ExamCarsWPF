namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesSmcsCodeMachineSystem")]
    public partial class TablesSmcsCodeMachineSystem
    {
        [Key]
        public int intSmcsCodeMachineSystem { get; set; }

        public int? intSMCSComponentID { get; set; }

        public int? intMachineSystem { get; set; }

        public virtual TablesMachineSystem TablesMachineSystem { get; set; }

        public virtual TablesSMCSComponent TablesSMCSComponent { get; set; }
    }
}
