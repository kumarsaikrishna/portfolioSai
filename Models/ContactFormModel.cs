﻿using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class ContactFormModel
    {
        [Required(ErrorMessage = "Full name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        public string Subject { get; set; }

        [Required(ErrorMessage = "Message is required")]
        public string Message { get; set; }
    }
}