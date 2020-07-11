using System;
using System.ComponentModel.DataAnnotations;

namespace ASPproject.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Fyll i titel!")]
        [Display(Name = "Titel")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Fyll i meddelande!")]
        [Display(Name = "Meddelande")]
        public string Message { get; set; }

        [Required(ErrorMessage = "Fyll i datum!")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [Display(Name = "Datum")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public News()
        {
        }
    }
}
