using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio_2._0.Models
{
    public class Translation
    {
        public int TranslationId { get; set; }
        public string ObjectId { get; set; }
        public int LanguageId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
    }
}