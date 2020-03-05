using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Entities.EntityInterface
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
