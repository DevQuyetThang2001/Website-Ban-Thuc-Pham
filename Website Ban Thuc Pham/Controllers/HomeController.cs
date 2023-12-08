using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Website_Ban_Thuc_Pham.Models;

namespace Website_Ban_Thuc_Pham.Controllers
{
    public class HomeController : Controller
    {
        Bantraicayraucu1Context db = new Bantraicayraucu1Context();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var lstsanpham = db.SanPhams.ToList();
            return View(lstsanpham);
        }

        public IActionResult SanPhamTheoloai(string maloai)
        {
            List<SanPham> lstsanpham = db.SanPhams.Where
                (x=>x.MaLoai==maloai).OrderBy(x=>x.TenSp).ToList();
            return View(lstsanpham);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}