using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcso_group2_pcsodb.Model
{
    public partial class Department
    {

        public int id { get; set; }

        public string? name { get; set; }

        public int sectorID { get; set; }

        public int numberOfProject { get; set; }

        public string? percentageProj { get; set; }

        public string remarks { get; set; }
    }
}
