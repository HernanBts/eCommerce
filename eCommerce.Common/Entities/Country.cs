﻿using System.ComponentModel.DataAnnotations;

namespace eCommerce.Common.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} must contain less than {1} characters.")]
        [Required]
        public string Name { get; set; }
    }
}
