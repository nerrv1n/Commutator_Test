using System;
using System.ComponentModel.DataAnnotations;

namespace Commutator.Models
{

    public class DateRangeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var switchModel = (Commutator.Models.Switch)validationContext.ObjectInstance;

            if (switchModel.PurchaseDate.HasValue && switchModel.InstallationDate.HasValue)
            {
                if (switchModel.InstallationDate < switchModel.PurchaseDate)
                {
                    return new ValidationResult("Дата установки должна быть позже даты покупки.");
                }
            }
            return ValidationResult.Success;
        }
    }
    public class Switch
    {
        public int Id { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        [RegularExpression(@"^\d{1,3}(\.\d{1,3}){3}$", ErrorMessage = "Неверный IP - Адрес")]
        public string IpAddress { get; set; }

        [Required]
        [RegularExpression(@"^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$", ErrorMessage = "Неверный MAC - Адрес")]
        public string MacAddress { get; set; }

        public int? Vlan { get; set; }
        public string SerialNumber { get; set; }
        public string InventoryNumber { get; set; }
        public DateTime? PurchaseDate { get; set; }
        [DateRange]
        public DateTime? InstallationDate { get; set; }
        public string Floor { get; set; }
        public string Comment { get; set; }
    }

}
