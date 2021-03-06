﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Open.Core
{
    public interface IObjectsRepository<T>
    {
        Task<T> GetObject(string id);

        Task<IEnumerable<T>> GetObjectsList();

        Task<T> AddObject(T o);

        Task UpdateObject(T o);

        Task DeleteObject(T o);
    }

}
