using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    //GenericService'imi oluşturdum.
    public interface IGenericService<T>
    {
        List<T> TGetList();
        T TGetById(int id);
    }
}
