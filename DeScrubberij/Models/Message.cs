using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DeScrubberij.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Bericht")]
        public string Comment { get; set; }

        [Required]
        [Display(Name = "Datum geplaatst")]
        public DateTime DatePosted { get; set; }

        [Required]
        [Display(Name = "Gebruiker")]
        public ApplicationUser User { get; set; }

        [Required]
        [Display(Name = "Auto")]
        public Car Car { get; set; }
    }
}