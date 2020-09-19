using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Http.Results;

namespace ParcialAlbertoMarin.Models
{
    public class Country
    {
        [Key]
        [Required]
        [StringLength(3, MinimumLength = 2)]
        public string Alpha3Code { get; set; }

        [Required]
        [StringLength(24, MinimumLength = 2)]
        public string Region { get; set; }

        [Required]
        [StringLength(24, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        public float Area { get; set; }

        [Required]
        public int CallingCodes { get; set; }

        [Required]
        [DataType(DataType.Url, ErrorMessage = "Url no Valido")]
        [Url]
        public string Flag { get; set; }

        public List<Language> Languages { get; set; }

    }

    public class Language
    {
        [Key]
        [Required]
        [StringLength(3, MinimumLength = 2)]
        public string Iso639_1 { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 2)]
        public string Iso639_2 { get; set; }

        [Required]
        public string Name2 { get; set; }

        [Required]
        public string NativeName { get; set; }
    }

}