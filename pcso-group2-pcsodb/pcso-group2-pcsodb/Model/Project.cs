using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcso_group2_pcsodb.Model
{
    public partial class Project
    {
        public int id { get; set; }

        public string? name { get; set; }

        public string? sectorID { get; set; }

        public string? departmentID { get; set; }

        public string? projectPercentage { get; set; }
    }
}
