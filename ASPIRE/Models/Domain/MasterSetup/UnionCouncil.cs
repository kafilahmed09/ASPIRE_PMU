﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPIRE.Models.Domain.MasterSetup
{
    [Table("UnionCouncil", Schema = "master")]
    public class UnionCouncil
    {
        [Key]
        public int UnionCouncilId { get; set; }
        [Display(Name = "Union Council")]
        public string UnionCouncilName { get; set; }
        public int TehsilId { get; set; }        
        public virtual Tehsil Tehsil { get; set; }
    }
}
