﻿using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Entities.EntityInterface;

namespace ClassLibrary.Entities
{
    public class User : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
    }
}
