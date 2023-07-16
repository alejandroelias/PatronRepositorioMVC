using System;
using System.Linq.Expressions;

namespace PatronRepositorioMVC.Data
{
    interface IRepository<T>
    {
        //CRUD
        void Add(T model);
        void Delete(int modelID);
        void Update(T model);
        void Count(Expression<Func<T,bool>> where);
        T GetByID(int modelID);
        //IEnumerable<T> FindBy(ParametersForQuery<T> parametersForQuery);
    }
}
