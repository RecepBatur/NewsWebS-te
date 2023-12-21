using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    //GenericRepository sınıfını tanımladım.
    public class GenericRepository<T> : IGenericDal<T> where T : class // IGenericDal<T> referans olarak aldım. Aynı zamanda T'nin bir class türünde olması gerektiğini belirttim.
    {
        public T GetById(int id)
        {
            using var c = new Context(); //Bir context nesnesi oluşturdum.
            return c.Set<T>().Find(id); //DbSet<T> veritabanında bir tabloyu temsil ediyor.(Yani entity) geriye belirtilen id'ye sahip nesne find ile bulunur ve döndürülür.
        }

        public List<T> GetList()
        {
            using var c = new Context(); //Bir context nesnesi oluşturdum.
            return c.Set<T>().ToList(); //DbSet<T> veritabanında bir tabloyu temsil ediyor.(Yani entity) geriye ilgili entity liste halinde döndürülür.
        }
    }
}
