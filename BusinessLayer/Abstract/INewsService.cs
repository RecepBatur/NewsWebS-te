using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface INewsService : IGenericService<News> //IGenericService<News> entity'si ile beraber referans aldım.
    {
        //İlgili metot imzalarımı tanımladım.
        List<News> TGetListNews();
        List<News> TGetListNewsByCategory(string category);
        List<News> TSearchNewsByKeyword(string keyword);
    }
}
