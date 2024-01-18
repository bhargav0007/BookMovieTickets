﻿using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Interface
{
    public interface IUserService
    {
        Task<User> Get(long Id);

        Task<IEnumerable<User>> GetAll();
    }
}
