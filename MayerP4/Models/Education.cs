using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MayerP4.Models
{
    public class Education
    {
        public int EducationID { get; set; }
        public string Degree { get; set; }
        public DateTime End { get; set; }
        public DateTime Start { get; set; }
        public string School { get; set; }
    }
}
