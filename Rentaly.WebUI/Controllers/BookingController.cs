using Microsoft.AspNetCore.Mvc;
using Rentaly.BusinessLayer.Abstract;
using Rentaly.EntityLayer.Entities;

namespace Rentaly.WebUI.Controllers
{
    public class BookingController : Controller
    {
        private readonly IBookingService _bookingService;
        private readonly ICarService _carService;

        public BookingController(
            IBookingService bookingService,
            ICarService carService)
        {
            _bookingService = bookingService;
            _carService = carService;
        }

        public async Task<IActionResult> BookingList()
        {
            var values = await _bookingService.TGetListAsync();
            return View(values);
        }

        public IActionResult Campaign()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateBooking(int id)
        {
            ViewBag.carId = id;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBooking(Booking booking)
        {
            booking.IsApproved = false;

            booking.CarName = "Araç #" + booking.CarId;

            await _bookingService.TInsertAsync(booking);

            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}