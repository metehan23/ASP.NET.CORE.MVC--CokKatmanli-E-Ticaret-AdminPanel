using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FreshShop.Model.ViewModels
{
    public class ManagerLogInVm
    {

        [Required(ErrorMessage ="Kullanıcı Adı Zorunludur")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre Zorunludur.")]
        [MinLength(3,ErrorMessage = "Şifre En Az 3 Karakter Olmalıdır.")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
