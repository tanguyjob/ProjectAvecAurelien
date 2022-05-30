using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL
{
    public interface IRepository<TKey,TEntity>
    {
        //create
       TKey Insert(TEntity entity);

        //read

        IEnumerable<TEntity> GetAll();

        TEntity GetById(TKey id);

        //update

        bool Update(TKey id, TEntity entity);

        //delete

        bool Delete(TKey id);
    }
}
