using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DeScrubberij.Models
{
    public class Photo
    {
        public int Id { get; set; }

        [Display(Name = "Auto")]
        public Car Car { get; set; }

        [Display(Name = "Bestandsnaam")]
        public string Filename { get; set; }
    }
}