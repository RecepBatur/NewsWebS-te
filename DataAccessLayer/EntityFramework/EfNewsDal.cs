using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfNewsDal : GenericRepository<News>, INewsDal //EfNewsDal GenericRepository<News> entity'si ile referans alıyor. Aynı zamanda INewsDal interface'sini referans ediyorum.
    {

        public List<News> GetListNews() //Haberleri listelediğim metot.
        {
            using (var context = new Context())
            {
                return context.Newses.Include(x => x.Category).ToList();
            }
        }

        public List<News> GetListNewsByCategory(string category) //Haberleri categorisine göre listelediğim metot.
        {
            using (var context = new Context())
            {
                return context.Newses
                    .Where(x => x.Category.CategoryName == category).ToList();
            }
        }
        public List<News> SearchNewsByKeyword(string keyword) //Aranılacak kelimeye göre ilgili haberi getiren metot.
        {
            using (var context = new Context())
            {
                return context.Newses.Where(x => x.Title.Contains(keyword)).ToList(); //aranılacak kelimeyi contains sorgusu ile ilgili haber başlığında arayıp listeletiyorum.
            }
        }
    }
}
