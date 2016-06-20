using System;
using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name= "Name")]
        [StringLength(50)]
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }

        [Display(Name = "UM")]
        [Required(ErrorMessage = "UM is required")]
        public string UM { get; set; }

        [Display(Name = "EAN Code")]
        public string EANCode { get; set; }

        [Display(Name = "Conversion Rate")]
        //[DataType(DataType.)]
        [Required(ErrorMessage = "Conversion Rate is required")]
        public double ConversionRate { get; set; }

        [Display(Name = "Expiration Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public Nullable<DateTime> ExpirationDate { get; set; }

        [Display(Name = "Production Date")]
        [DataType(DataType.Date)]
        public Nullable<DateTime> ProductionDate { get; set; }
    }
}
