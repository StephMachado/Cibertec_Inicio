using System;
using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "UM")]
        [Required(ErrorMessage = "UM is required")]
        public string UM { get; set; }

        [Display(Name = "EAN Code")]
        public string EANCode { get; set; }

        [Display(Name = "Conversion Rate")]
        [Required(ErrorMessage = "Conversion Rate is required")]
        public double ConversionRate { get; set; }

        private DateTime _dDate = DateTime.MinValue;
        [Display(Name = "Expiration Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Date Only")]
        public Nullable<DateTime> ExpirationDate
        {
            get
            {
                return (_dDate == DateTime.MinValue) ? DateTime.Now : _dDate;
            }

            set
            {
                _dDate = DateTime.Now;
            }
        }

        [Display(Name = "Production Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Date Only")]
        public Nullable<DateTime> ProductionDate
        {
            get
            {
                return (_dDate == DateTime.MinValue) ? DateTime.Now : _dDate;
            }

            set
            {
                _dDate = DateTime.Now;
            }
        }

    }
}
