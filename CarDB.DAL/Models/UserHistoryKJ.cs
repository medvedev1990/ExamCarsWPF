namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserHistoryKJ")]
    public partial class UserHistoryKJ
    {
        public int Id { get; set; }

        public DateTime EnterDateTime { get; set; }

        public DateTime LeaveDateTime { get; set; }

        [Required]
        public string IPAddress { get; set; }

        public string Comment { get; set; }
    }
}
