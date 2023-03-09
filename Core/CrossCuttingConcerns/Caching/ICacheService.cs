﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheService
    {
        void Add(string key, object value,int duration);
        void Remove(string key);
        void RemoveByPattern(string pattern);
        bool IsAdd(string key);
        T Get<T>(string key);
        object Get(string key);
    }
}