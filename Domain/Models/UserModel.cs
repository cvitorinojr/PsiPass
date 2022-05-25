using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UserModel
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _crp;

        public string CRP
        {
            get { return _crp; }
            set { _crp = value; }
        }
        private int _userTypeId;

        public int UserTypeId
        {
            get { return _userTypeId; }
            set { _userTypeId = value; }
        }
        private int _userSpecialtyId;

        public int UserSpecialtyId
        {
            get { return _userSpecialtyId; }
            set { _userSpecialtyId = value; }
        }


    }
}
