using ASPIRE.Models.Domain.MasterSetup;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPIRE.Models.Domain.Schools
{
    [Table("IndicatorEvidence", Schema = "Schools")]
    public class IndicatorEvidence
    {
        [Key]        
        public int IndicatorEvidenceId { get; set; }
        public int IndicatorId { get; set; }
        public int SchoolId { get; set; }
        public int FileTypeId { get; set; }
        public string ImageURL { get; set; }       
        public DateTime? DateOfUpload { get; set; }  
        public bool? IsVerified { get; set; }
        public string VerifiedBy { get; set; }
        public DateTime? VerifiedDate { get; set; }
        public virtual School School { get; set; }
        public virtual Indicator Indicator { get; set; }        
    }
}
