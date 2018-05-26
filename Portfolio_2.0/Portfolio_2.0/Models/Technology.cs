using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Portfolio_2._0.Models
{
    public class Technology
    {

        public int TechnologyId { get; set; }
        public string TechnologyName { get; set; }
        public string ImageFileName { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}