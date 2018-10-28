namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserHistorySet")]
    public partial class UserHistorySet
    {
        public int Id { get; set; }

        public DateTime TimeIn { get; set; }

        [Required]
        public string IpUser { get; set; }

        public DateTime TimeOut { get; set; }
    }
}
