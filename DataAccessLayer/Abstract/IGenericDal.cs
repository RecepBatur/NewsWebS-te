using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //Interface'ler için generic bir yapı kurmak istediğim için IGenericDal'ı oluşturdum. Tekrar tekrar her bir ınterface için aşağıdaki GetList ve GetById metotlarını yazmamak için.
    public interface IGenericDal<T>
    {
        List<T> GetList();
        T GetById(int id);
    }
}
