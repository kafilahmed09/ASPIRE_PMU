using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPIRE.Models.Domain.Views
{
    [Keyless]
    public class SupplySummary
    {
        public int Solar_Target { get; set; }
        public int Solar_GRN { get; set; }
        public int IT_Target { get; set; }
        public int IT_GRN { get; set; }
        public int Learn_Target { get; set; }
        public int Learn_GRN { get; set; }
        public int Science_Target { get; set; }
        public int Science_GRN { get; set; }
        public int Hygiene_Target { get; set; }
        public int Hygiene_GRN { get; set; }        
        public int MHM_Target { get; set; }
        public int MHM_GRN { get; set; }
        public int Internet_Target { get; set; }
        public int Internet_GRN { get; set; }
    }
}
