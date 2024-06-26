﻿using Models;
using Models.Enums;

namespace DataAccess
{
    public class Storage
    {
        public static StorageSet<User> Users { get; set; }


        public static StorageSet<Car> Cars { get; set; }

        public Storage()
        {
            Users = new StorageSet<User>();
            Cars = new StorageSet<Car>();
            if (!Users.GetAll().Any())
            {
                Users.Add(new User(0,"Admin","Admin","admin","admin123",RoleEnum.Admin));
            }
        }
    }
}
