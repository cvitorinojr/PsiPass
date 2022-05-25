using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.User
{
    public class UserDtoResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CRP { get; set; }
        public int UserTypeId { get; set; }
        public int UserSpecialtyId { get; set; }
    }
}
