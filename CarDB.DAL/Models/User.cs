namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            AccessUser = new HashSet<AccessUser>();
            TrackEvaluation = new HashSet<TrackEvaluation>();
        }

        [Key]
        public int intUserId { get; set; }

        [StringLength(1024)]
        public string SID { get; set; }

        [StringLength(512)]
        public string FirstName { get; set; }

        [StringLength(512)]
        public string LastName { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        public int? intLocationId { get; set; }

        public double? intLaborRate { get; set; }

        [StringLength(255)]
        public string strCraft { get; set; }

        [StringLength(1)]
        public string strShift { get; set; }

        [StringLength(20)]
        public string strOther { get; set; }

        public int? intSupplierId { get; set; }

        public int? intRecordsPerPage { get; set; }

        public DateTime? CreateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccessUser> AccessUser { get; set; }

        public virtual TablesLocation TablesLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackEvaluation> TrackEvaluation { get; set; }
    }
}
