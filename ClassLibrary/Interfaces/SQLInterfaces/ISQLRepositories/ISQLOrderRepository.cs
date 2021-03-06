﻿using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Entities;

namespace ClassLibrary.Interfaces.SQLInterfaces
{
    public interface ISQLOrderRepository : IGenericRepository<Order, int>
    {
        int Add(Order order);
        void Update(Order order);
    }
}
