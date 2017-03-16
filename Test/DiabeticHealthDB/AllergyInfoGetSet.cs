using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabeticHealthDB
{
    class AllergyInfoGetSet
    {
        public int AllergyInfoID { get; set; }
        public int PatientID { get; set; }
        public string AllergicTo { get; set; }
        public string Reaction { get; set; }
    }
}
