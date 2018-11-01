using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.util
{
    public abstract class ACrud<TEntity, TKey> where TEntity : class
    {
        public abstract List<TEntity> GetAll();
        public abstract TEntity GetById(TKey id);
        public abstract void Create(TEntity entity);
        public abstract void Update(TEntity entity);
        public abstract void Delete(TEntity entity);
    }
}
