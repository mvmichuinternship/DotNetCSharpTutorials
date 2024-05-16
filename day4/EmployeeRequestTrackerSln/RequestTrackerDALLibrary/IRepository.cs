using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerDALLibrary
{
    public interface IRepository<K, T> where T : class
    {
        T Add(T item);
        T Delete(K key);
        T Get(K key);
        T Update(K key);
        IList<T> GetAll();
    }
}
