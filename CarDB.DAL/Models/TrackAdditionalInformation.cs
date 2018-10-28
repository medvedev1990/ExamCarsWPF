namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrackAdditionalInformation")]
    public partial class TrackAdditionalInformation
    {
        [Key]
        public int intAdditionalInformation { get; set; }

        public int? intEquipmentID { get; set; }

        public double? floatUseOfFuel { get; set; }

        public double? floatTransportedTons { get; set; }

        public int? datePeriod { get; set; }

        public int? dateYear { get; set; }

        public DateTime? dateCreateDate { get; set; }

        public virtual newEquipment newEquipment { get; set; }
    }
}
