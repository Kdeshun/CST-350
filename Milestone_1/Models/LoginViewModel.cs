using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Minesweeper.Models
{
    public class LoginViewModel
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
