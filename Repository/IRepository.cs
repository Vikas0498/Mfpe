using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MfpeDrugsApi.Repository
{
    public interface IRepository<T>
    {
        void Add(T item);
        T Get(int id);
        T Get(string name);
        //T PUT(int id,string location);
        public bool Check(int id,string location);
    }
}
