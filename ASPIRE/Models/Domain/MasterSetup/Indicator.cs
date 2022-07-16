using ASPIRE.Models.Domain.Schools;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPIRE.Models.Domain.MasterSetup
{
    [Table("Indicator", Schema = "master")]
    public class Indicator
    {
        [Key]
        public int IndicatorId { get; set; }        
        public string IndicatorName { get; set; }        
        public bool IsMultiple { get; set; } = false;
        public bool IsActive { get; set; } = true;        
    }
}
