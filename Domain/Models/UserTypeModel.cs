using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UserTypeModel
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
