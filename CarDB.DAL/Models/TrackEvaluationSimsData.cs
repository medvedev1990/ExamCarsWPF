namespace CarDB.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrackEvaluationSimsData")]
    public partial class TrackEvaluationSimsData
    {
        [Key]
        public int intSimsId { get; set; }

        public int intEvaluationPartId { get; set; }

        public int intEvalutionId { get; set; }

        [StringLength(250)]
        public string strGroupNumber { get; set; }

        [StringLength(250)]
        public string strBreakdownCode { get; set; }

        [StringLength(250)]
        public string strDescription { get; set; }

        public bool bitWorkingCondition { get; set; }

        public int? intSimsCodeId { get; set; }

        public virtual TablesSimsCode TablesSimsCode { get; set; }

        public virtual TrackEvaluation TrackEvaluation { get; set; }

        public virtual TrackEvaluationPart TrackEvaluationPart { get; set; }
    }
}
