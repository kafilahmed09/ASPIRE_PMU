using ASPIRE.Models.Domain.MasterSetup;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPIRE.Models.Domain.Schools.Interventions
{
    [Table("Intervention", Schema = "school")]
    public class Intervention
    {
        [Key]
        public int InterventionId { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactNumber { get; set; }
        public bool IsSolarization { get; set; }
        public bool IsITLab { get; set; }
        public bool IsInternetConnectivity { get; set; }
        public bool IsScienceLabEquipment { get; set; }
        public bool IsHygieneKit { get; set; }
        public bool IsLearningKit { get; set; }
        public bool IsMHMKit { get; set; }
        public bool IsdistanceLearningKit { get; set; }


        [ForeignKey("School")]
        [Display(Name = "School")]
        public int SchoolId { get; set; }
        public virtual School School { get; set; }
    }
}
