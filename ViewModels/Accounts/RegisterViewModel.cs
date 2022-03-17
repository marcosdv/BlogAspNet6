﻿using System.ComponentModel.DataAnnotations;

namespace BlogAspNet6.ViewModels.Accounts
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "O nome é obrigatório!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório!")]
        [EmailAddress(ErrorMessage = "O e-mail é inválido!")]
        public string Email { get; set; }
    }
}