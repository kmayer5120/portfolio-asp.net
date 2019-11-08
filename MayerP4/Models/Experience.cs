using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MayerP4.Models
{
    public class Experience
    {
        public int ExperienceID { get; set; }
        public string Description { get; set; }
        public DateTime End { get; set; }
        public DateTime Start { get; set; }
        public string Title { get; set; }

    }
}
