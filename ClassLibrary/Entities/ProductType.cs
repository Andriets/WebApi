using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Entities.EntityInterface;

namespace ClassLibrary.Entities
{
    class ProductType : IEntity<int>
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
    }
}
