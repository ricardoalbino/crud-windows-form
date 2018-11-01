using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.util
{
    interface ICrud<TEntity>
    {
        void Create(TEntity entity);
       // List<TEntity> Retrieve();
        void Update(TEntity entity);
        void Delete(int id);
        TEntity GetByID(int id);
    }
}
