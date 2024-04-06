using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public interface IGenericRepository<TModel>
    {
        TModel Get(int id);
        IEnumerable<TModel> GetAll();
        int Create(TModel model);
        bool Update(TModel model);
        bool Delete(int id);
    }
}
