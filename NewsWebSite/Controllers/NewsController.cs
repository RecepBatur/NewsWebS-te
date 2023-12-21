using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;
namespace NewsWebSite.Controllers
{
    public class NewsController : Controller
    {
        // NewsManager'dan bir nesne türettim
        NewsManager newsManager = new NewsManager(new EfNewsDal());

        private readonly INewsService _newsService;

        public NewsController(INewsService newsService) //Constructor metodunu uygualadım. INewsService türünde newsService parametresi alır.
        {
            _newsService = newsService;
        }

        public IActionResult Index(int page = 1) //Anasayfada tüm haberleri TGetListNews metodu ile çekip, ToPagedList metodunu kullanarak paging işlemini uyguladım. int türünde page parametresi verip, birden başlasın dedim.
        {
            var values = _newsService.TGetListNews().ToPagedList(page, 5); //page, 5 yani her sayfada beş haber olsun dedim.
            return View(values); //ilgili verileri geriye döndürdüm.
        }
        public IActionResult NewsDetails(int id) // Belirli haberin detaylarını gösteren action metodu. TGetById metodu kullanılarak ilgili haber id'ye göre getirilir.
        {
            var values = newsManager.TGetById(id);
            return View(values); //ilgili verileri geriye döndürdüm.
        }
        public IActionResult FilterByCategory(string category, int page = 1) //Belirli bir kategoriye göre haberleri filtreleyen Action metodu. TGetListNewsByCategory metodu ile belirli bir kategoriye ait haberler çekilir, geriye dönen sonuç Index'e gönderilir.
        {
            var filteredNews = _newsService.TGetListNewsByCategory(category).ToPagedList(page, 5);
            return View("Index", filteredNews);
        }
        public IActionResult SearchByKeyword(string keyword, int page = 1) //Belirli bir anahtar kelimeye göre haberleri arayan Action metodu. TSearchNewsByKeyword metodu ile anahtar kelimeye göre haberler çekilir, geriye dönen sonuç Index'e gönderilir.
        {
            var searchResults = _newsService.TSearchNewsByKeyword(keyword).ToPagedList(page, 5);
            return View("Index", searchResults);
        }
    }
}
