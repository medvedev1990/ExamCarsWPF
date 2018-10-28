namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesQuantity")]
    public partial class TablesQuantity
    {
        [Key]
        public int intQuantityId { get; set; }

        [Required]
        [StringLength(2)]
        public string strQuantityName { get; set; }

        public int? intSMCSQuantityId { get; set; }

        [StringLength(25)]
        public string strDescription { get; set; }

        public virtual TablesSMCSQuantity TablesSMCSQuantity { get; set; }
    }
}
