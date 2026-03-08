using System.ComponentModel.DataAnnotations;

namespace FodboldKlub.Models
{
    public class Medlem
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Fornavn er påkrævet.")]
        public string Fornavn { get; set; }

        [Required(ErrorMessage = "Efternavn er påkrævet.")]
        public string Efternavn { get; set; }

        [Required(ErrorMessage = "Adresse er påkrævet.")]
        public string Adresse { get; set; }

        [Required(ErrorMessage = "Telefon er påkrævet.")]
        public string Telefon { get; set; }

        [Required(ErrorMessage = "Email er påkrævet.")]
        public string Email { get; set; }
    }
}
