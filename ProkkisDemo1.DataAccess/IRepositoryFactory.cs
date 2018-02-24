﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProkkisDemo1.DataAccess
{
    public interface IRepositoryFactory
    {
        TRepository CreateRepository<T, TRepository>() where TRepository : IRepository<T>;
    }
}