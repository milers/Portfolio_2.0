using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio_2._0.Models
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }

        public ICollection<Translation> Translations { get; set; }
    }
}