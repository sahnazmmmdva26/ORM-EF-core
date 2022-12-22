using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzamizzaTask.Helper
{
    internal interface IService<T>
    {
        void Add(T model);
        void Delete(int Id);
        void Update(T model);
        T GetById(int Id);
        List<T> GetAll();

    }
}
