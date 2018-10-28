namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsersLocation")]
    public partial class UsersLocation
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1024)]
        public string SID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int intLocationId { get; set; }

        public virtual TablesLocation TablesLocation { get; set; }
    }
}
