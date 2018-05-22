using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DeScrubberij.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Gebruiker")]
        public ApplicationUser User { get; set; }

        [Required]
        [Display(Name = "Reservering")]
        public Reservation Reservation { get; set; }
    }
}