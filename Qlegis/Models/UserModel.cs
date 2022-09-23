
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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
        public int FirstName { get; set; }

        [Display(Name = "LastName")]
        [Column("LastName")]
        public int LastName { get; set; }

        [Display(Name = "Email")]
        [Column("Email")]
        public int Email { get; set; }

        [Display(Name = "Password")]
        [Column("Password")]
        public int Password { get; set; }

        [Display(Name = "ConfirmPassword")]
        [Column("ConfirmPassword")]
        public int ConfirmPassword { get; set; }

        [Display(Name = "NumberPhoneCell")]
        [Column("NumberPhoneCell")]
        public int NumberPhoneCell { get; set; }

        [Display(Name = "ImageAvatarPerfil")]
        [Column("ImageAvatarPerfil")]
        public int ImageAvatarPerfil { get; set; }

        [Display(Name = "State")]
        [Column("State")]
        public int State { get; set; }
    }
}
