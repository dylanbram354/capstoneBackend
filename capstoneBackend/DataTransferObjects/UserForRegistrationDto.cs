﻿using System.ComponentModel.DataAnnotations;

namespace capstoneBackend.DataTransferObjects
{
    public class UserForRegistrationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PreferredContact { get; set; }
        public string ParentEmail { get; set; }
        public string ParentPhone { get; set; }

        public string Role { get; set; }
    }
}
