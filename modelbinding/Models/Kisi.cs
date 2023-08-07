using System.ComponentModel.DataAnnotations;

namespace modelbinding.Models
{
    public class Kisi
    {
        [Required(ErrorMessage = "Ad alani zorunludur")] // ad alaninda Ad yerine {0} da kullanabiliriz
        [MaxLength(20, ErrorMessage = "Ad alani en fazla 20 karakter olabilir")]
        // bu ikisine data annotation deniyor
        public string Ad { get; set; } = null!;
    }
}
