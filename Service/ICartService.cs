﻿using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface ICartService
    {
        ShoppingCart GetById(int id);
        Task CreateAsSync(ShoppingCart cart);
        Task UpdateAsSync(ShoppingCart cart);
        Task UpdateById(int id);
        Task DeleteAsSync(int id);
        ShoppingCart GetByUserId(string id);
    }
}
