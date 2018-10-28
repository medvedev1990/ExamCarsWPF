namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserHistory")]
    public partial class UserHistory
    {
        public int UserHistoryId { get; set; }

        [StringLength(20)]
        public string UserIP { get; set; }

        public DateTime? EnterTime { get; set; }

        public DateTime? LeaveTime { get; set; }

        public string Comment { get; set; }
    }
}
