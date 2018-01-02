﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkGuids.Model
{
    public class User
    {

        public Guid Id { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string LastUpdateUser { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

    }
}
