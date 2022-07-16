using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPIRE.Models.Domain.MasterSetup
{
    [Table("Enrollment", Schema = "School")]
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }
        public int KachiBoys { get; set; }
        public int KachiGirls { get; set; }
        public int PakiBoys { get; set; }
        public int PakiGirls { get; set; }
        public int TwoBoys { get; set; }
        public int TwoGirls { get; set; }
        public int ThreeBoys { get; set; }
        public int ThreeGirls { get; set; }
        public int FourBoys { get; set; }
        public int FourGirls { get; set; }
        public int FiveBoys { get; set; }
        public int FiveGirls { get; set; }
        public int SixBoys { get; set; }
        public int SixGirls { get; set; }
        public int SevenBoys { get; set; }
        public int SevenGilrs { get; set; }
        public int EightBoys { get; set; }
        public int EightGilrs { get; set; }
        public int NineBoys { get; set; }
        public int NineGirls { get; set; }
        public int TenBoys { get; set; }
        public int TenGirls { get; set; }
        public int ElevenBoys { get; set; }
        public int ElevenGirls { get; set; }
        public int TwelveBoys { get; set; }
        public int TwelveGilrs { get; set; }
        public int TotalSchoolProfileStudent { get; set; }
        public int TotalStudentProfileEntered { get; set; }
    }
}
