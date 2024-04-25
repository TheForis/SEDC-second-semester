﻿namespace Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        protected BaseEntity()
        {
            Random rnd = new Random();
            Id = rnd.Next(1,int.MaxValue);
        }
    }
}
