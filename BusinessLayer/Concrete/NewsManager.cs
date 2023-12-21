using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    //Manager sınıflarımı oluşturdum.
    public class NewsManager : INewsService //INewsService referans olarak alıp ilgili metot imzalarını implement ettim.
    {
        //Constructor metodum ile dependency ınjection enjekte ettim.
        INewsDal _newsDal;

        public NewsManager(INewsDal newsDal) 
        {
            _newsDal = newsDal;
        }

        public News TGetById(int id) //id'ye göre haberi getiren metot.
        {
          return _newsDal.GetById(id);
        }

        public List<News> TGetList()
        {
            return _newsDal.GetList();
        }

        public List<News> TGetListNews() // Bütün haberleri listeyen metot.
        {
            return _newsDal.GetListNews();
        }

        public List<News> TGetListNewsByCategory(string category) // Belirli bir kategoriye ait olan haberleri getirir. String türünde category parametresini alır.
        {
            return _newsDal.GetListNewsByCategory(category);
        }

        public List<News> TSearchNewsByKeyword(string keyword) // Belirli bir anahtar kelimeye göre haberleri getiren metot. String türünde keyword parametresi alır.
        {
            return _newsDal.SearchNewsByKeyword(keyword);
        }
    }
}
