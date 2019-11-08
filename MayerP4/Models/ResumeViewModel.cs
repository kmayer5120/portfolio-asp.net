using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MayerP4.Models
{
    public class ResumeViewModel
    {
        public string Intro { get; set; }
        public List<Skill> Skils { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Education> Educations { get; set; }
        public string Conclusion { get; set; }
    }
}
