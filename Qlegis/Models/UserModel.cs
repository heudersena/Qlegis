using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Qlegis.Models
{
    [Table("user")]
    public class UserModel
    {

        [Display(Name = "id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "FirstName")]
        [Column("FirstName")]
        public string? FirstName { get; set; }

        [Display(Name = "LastName")]
        [Column("LastName")]
        public string? LastName { get; set; }

        [Display(Name = "Email")]
        [Column("Email")]
        public string? Email { get; set; }

        [Display(Name = "Password")]
        [Column("Password")]
        public string? Password { get; set; }

        [Display(Name = "ConfirmPassword")]
        [Column("ConfirmPassword")]
        public string? ConfirmPassword { get; set; }

        [Display(Name = "NumberPhoneCell")]
        [Column("NumberPhoneCell")]
        public string? NumberPhoneCell { get; set; }

        [Display(Name = "ImageAvatarPerfil")]
        [Column("ImageAvatarPerfil")]
        public string? ImageAvatarPerfil { get; set; }

        [Display(Name = "State")]
        [Column("State")]
        public string? State { get; set; }
    }
}
