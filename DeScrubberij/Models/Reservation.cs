using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DeScrubberij.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [Display(Name = "Auto")]
        public Car Car { get; set; }

        [Display(Name = "Startdatum")]
        public DateTime BeginDate { get; set; }

        [Display(Name = "Einddatum")]
        public DateTime EndDate { get; set; }
    }
}