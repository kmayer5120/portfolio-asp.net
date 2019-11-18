using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MayerP4.Data;

namespace MayerP4.Models
{
    public class ResumeViewModel
    {
        private ApplicationDbContext db;

        public string Intro { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Education> Educations { get; set; }
        public string Conclusion { get; set; }

        public ResumeViewModel()
        {
        }

    }
}
