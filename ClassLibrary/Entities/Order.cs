using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Entities.EntityInterface;

namespace ClassLibrary.Entities
{
    public class Order : IEntity<int>
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CountOfProduct { get; set; }
        public float OrderSum { get; set; }
        public int UserId { get; set; }
        public DateTime DateOfOrder { get; set; }
    }
}
