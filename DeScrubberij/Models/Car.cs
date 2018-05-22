using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DeScrubberij.Models
{
    public class Car
    {
        public int Id { get; set; }
        
        [Display(Name = "Kenteken")]
        public string LicensePlate { get; set; }

        [Required]
        [Display(Name = "Merk")]
        public Brand Brand { get; set; }

        [Required]
        [Display(Name = "Type")]
        public string Type { get; set; }

        [Display(Name = "Bouwjaar")]
        public DateTime YearBuilt { get; set; }

        [Display(Name = "Prijs")]
        public decimal Price { get; set; }

        [Display(Name = "Kilometerstand")]
        public int Mileage { get; set; }

        [Display(Name = "Brandstof")]
        public FuelEnum Fuel { get; set; }

        [Display(Name = "Transmissie")]
        public TransmissionEnum Transmission { get; set; }

        [Display(Name = "Apk verloopdatum")]
        public DateTime ApkExpiration { get; set; }

        [Display(Name = "BTW")]
        public bool HasBtw { get; set; }

        [Display(Name = "Foto bestandsnaam")]
        public string PhotoFileName { get; set; }

        [Display(Name = "Extra informatie")]
        public string ExtraInfo { get; set; }

        [Display(Name = "Soort")]
        public KindEnum Kind { get; set; }
    }

    public enum FuelEnum
    {
        Benzine,
        Diesel,
        LPG,
        Elektrisch,
        Hybrid
    }

    public enum TransmissionEnum
    {
        Automatisch,
        Handmatig
    }

    public enum KindEnum
    {
        Personenwagen,
        Bestelbus
    }
}