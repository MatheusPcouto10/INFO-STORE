using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoA1.IDao
{
    interface IDaoFornecedor<T>
    {
        void create(T t);
        void update(T t, int id);
        void delete(int id);
        T findById(int id);
    }
}
