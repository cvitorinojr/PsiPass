using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.User
{
    public class UserDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Email invalido") ]
        public string Email { get; set; }
        [Required]
        [MaxLength(6)]
        public string CRP { get; set; }
        [Required]
        public int UserTypeId { get; set; }
        [Required]
        public int UserSpecialtyId { get; set; }

    }
}
