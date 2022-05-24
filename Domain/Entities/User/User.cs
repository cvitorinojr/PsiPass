using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.User
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string CRP { get; set; }
        public virtual UserType UserType { get; set; }
        public virtual UserSpecialty UserSpecialty { get; set; }

    }
}
