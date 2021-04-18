using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesIdentityCrud.Models
{
    public class Urun
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad gir.")]
        public string UrunAd { get; set; }

        [Required(ErrorMessage = "Birim fiyat gir.")]
        public decimal BirimFiyat { get; set; }
    }
}
