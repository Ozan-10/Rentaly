using Microsoft.AspNetCore.Mvc;
using Rentaly.BusinessLayer.Abstract;

namespace Rentaly.WebUI.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IProcessService _processService;
        private readonly ICarService _carService;
        private readonly IBookingService _bookingService;

        public DashboardController(
            IAboutService aboutService,
            IProcessService processService,
            ICarService carService,
            IBookingService bookingService)
        {
            _aboutService = aboutService;
            _processService = processService;
            _carService = carService;
            _bookingService = bookingService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.aboutCount = (await _aboutService.TGetListAsync()).Count;
            ViewBag.processCount = (await _processService.TGetListAsync()).Count;

            ViewBag.totalCar = (await _carService.TGetListAsync()).Count;
            ViewBag.totalBooking = (await _bookingService.TGetListAsync()).Count;

            return View();
        }
    }
}