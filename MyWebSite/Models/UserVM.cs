using System.ComponentModel.DataAnnotations;

namespace MyWebSite.Models
{
    public class UserVM
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Lütfen isim alanını boş geçmeyiniz.")]
        [MaxLength(20, ErrorMessage = "İsim alanı en fazla 20 karakter olabilir.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lütfen soyisim alanını boş geçmeyiniz.")]
        [MaxLength(20, ErrorMessage = "Soyisim alanı en fazla 20 karakter olabilir.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Lütfen e-mail alanını boş geçmeyiniz.")]
        [MaxLength(50, ErrorMessage = "E-mail alanı en fazla 50 karakter olabilir.")]
        [EmailAddress(ErrorMessage = "Lütfen e-mail adresi formatında giriş yapınız.")]
        public string EMail { get; set; }

        [Required(ErrorMessage = "Lütfen şifre alanını boş geçmeyiniz.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen cinsiyet alanını boş geçmeyiniz.")]
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Man,
        Woman,
        Other
    }
}