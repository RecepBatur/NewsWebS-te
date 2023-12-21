using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface INewsDal : IGenericDal<News> //IGenericDal'ı news entity'si ile beraber referans olarak alıyorum.
    {
        //İlgili metot imzalarımı tanımladım.
        public List<News> GetListNews();
        List<News> GetListNewsByCategory(string category);
        List<News> SearchNewsByKeyword(string keyword);
    }
}
