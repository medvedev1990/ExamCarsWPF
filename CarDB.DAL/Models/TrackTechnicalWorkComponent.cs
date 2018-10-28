namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrackTechnicalWorkComponent")]
    public partial class TrackTechnicalWorkComponent
    {
        [Key]
        public int intTechnicalWorkComponentId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dCreateDate { get; set; }

        public int? intMetered { get; set; }

        public int? intSMCSJob { get; set; }

        public int? intSMCSComponentID { get; set; }

        [StringLength(512)]
        public string strDescription { get; set; }

        public int intTWComponentId { get; set; }

        public virtual TablesSMCSComponent TablesSMCSComponent { get; set; }

        public virtual TablesSMCSJob TablesSMCSJob { get; set; }

        public virtual TrackComponent TrackComponent { get; set; }
    }
}
