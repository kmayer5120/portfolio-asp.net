using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MayerP4.Models
{
    public class Education
    {
        public int EducationID { get; set; }

        public string Degree { get; set; }

        [DataType(DataType.Date)]
        public DateTime End { get; set; }

        [DataType(DataType.Date)]
        public DateTime Start { get; set; }
        
        public string School { get; set; }
    }
}
