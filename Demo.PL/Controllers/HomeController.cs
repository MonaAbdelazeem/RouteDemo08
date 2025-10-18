using Demo.BLL.Services.Interfaces;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace Demo.PL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISingltonServise singltonServise01;
        private readonly ISingltonServise singltonServise02;
        private readonly ITransientService transientService01;
        private readonly ITransientService transientService02;
        private readonly IScoppedServises scoppedServises01;
        private readonly IScoppedServises scoppedServises02;

        public HomeController(ILogger<HomeController> logger ,
            ISingltonServise SingltonServise01 , ISingltonServise SingltonServise02,
            ITransientService TransientService01 , ITransientService TransientService02,
            IScoppedServises ScoppedServises01 , IScoppedServises ScoppedServises02
            )
        {
            _logger = logger;
            singltonServise01 = SingltonServise01;
            singltonServise02 = SingltonServise02;
            transientService01 = TransientService01;
            transientService02 = TransientService02;
            scoppedServises01 = ScoppedServises01;
            scoppedServises02 = ScoppedServises02;
        }

        public string Index()
        {
            StringBuilder SB = new StringBuilder();
            SB.AppendLine($"Singlton Servise 01 = {singltonServise01.GetGuid()}");
            SB.AppendLine($"Singlton Servise 02 = {singltonServise02.GetGuid()}");

            SB.AppendLine($"Transient Service 01 = {transientService01.GetGuid()}");
            SB.AppendLine($"Transient Service 02 = {transientService02.GetGuid()}");

            SB.AppendLine($"Scopped Servises 01 = {scoppedServises01.GetGuid()}");
            SB.AppendLine($"Scopped Servises 02 = {scoppedServises02.GetGuid()}");

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
