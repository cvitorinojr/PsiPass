using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        private DateTime? createAt;

        public DateTime? CreateAt
        {
            get { return createAt; }
            set { createAt = (value == null ? DateTime.UtcNow: value); }
        }

        private DateTime? updateAt;

        public DateTime? UpdateAt
        {
            get { return createAt; }
            set { createAt = (value == null ? DateTime.UtcNow : value); }
        }


    }
}
