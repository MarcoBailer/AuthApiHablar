﻿using System.ComponentModel.DataAnnotations;

namespace AuthApiHablar.Core.Dtos
{
    public class UpdatePermissionDto
    {
        [Required(ErrorMessage = "Email is required")]
        public string UserName { get; set; }
    }
}
