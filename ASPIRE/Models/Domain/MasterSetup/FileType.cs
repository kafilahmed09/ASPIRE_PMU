using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPIRE.Models.Domain.MasterSetup
{
    [Table("FileType", Schema = "master")]
    public class FileType
    {
        [Key]
        public int FileTypeId { get; set; }
        [Required]        
        public string Name { get; set; }
        public string FileFilter { get; set; }        
    }
}
