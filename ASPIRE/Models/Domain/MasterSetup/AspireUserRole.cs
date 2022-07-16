using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPIRE.Models.Domain.MasterSetup
{
    [Table("AspireUserRole", Schema = "master")]
    public class AspireUserRole
    {
        [Key]
        public int AspireUserRoleId { get; set; }
        [Required]        
        public string Name { get; set; }
    }
}
