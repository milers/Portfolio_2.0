using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Portfolio_2._0.Models
{
    public class Project
    {

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ImageFileName { get; set; }
        public bool Visible { get; set; }
        public string GitHubUrl { get; set; }
        public int TechnologyId { get; set; }
        public Technology Technology { get; set; }
    }
}