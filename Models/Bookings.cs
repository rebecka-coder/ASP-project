using System;
using System.ComponentModel.DataAnnotations;

namespace ASPproject.Models
{
    public class Bookings
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Välj datum!")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datum")]
        public string Date { get; set; }

        [Required(ErrorMessage = "Välj tidpunkt!")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        [Display(Name = "Tid")]
        public string Time { get; set; }

        [Required(ErrorMessage = "Välj meny!")]
        [Display(Name = "Meny")]
        public string Menu { get; set; }

        [Display(Name = "Speciella önskemål")]
        public string Specials { get; set; }

        [Range(10, int.MaxValue, ErrorMessage = "Antal personer måste vara minst 10!")]
        [Display(Name = "Antal")]
        public int NumbersPeople { get; set; }
        

        [Required(ErrorMessage = "Fyll i för- och efternamn!")]
        [Display(Name = "För- och efternamn")]
        public string Name { get; set; }
        

        [Required(ErrorMessage = "Fyll i adress!")]
        [Display(Name = "Adress")]
        public string Address { get; set; }
        

        [Required(ErrorMessage = "Fyll i ort!")]
        [Display(Name = "Ort")]
        public string City { get; set; }

        [Required(ErrorMessage = "Fyll i telefonnummer!")]
        [Display(Name = "Telefonnummer")]
        public string Phonenumber { get; set; }

        [Required(ErrorMessage = "Fyll i e-post!")]
        [Display(Name = "E-post")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        public Bookings()
        {
        }
    }
}
