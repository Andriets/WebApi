using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Entities.EntityInterface;

namespace ClassLibrary.Entities
{
    public class Product : IEntity<int>
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int ProductTypeId { get; set; }
        public float Price { get; set; }
    }
}
