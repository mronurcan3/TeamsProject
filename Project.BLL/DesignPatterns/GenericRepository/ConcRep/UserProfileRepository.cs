﻿using Project.BLL.DesignPatterns.GenericRepository.BaseRep;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRep
{
    class UserProfileRepository:BaseRepository<UserProfile>
    {
        public UserProfileRepository()
        {

        }
    }
}
