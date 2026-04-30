using Microsoft.AspNetCore.Mvc;
using Rentaly.BusinessLayer.Abstract;
using System.Diagnostics;
using Rentaly.EntityLayer.Entities;

namespace Rentaly.WebUI.Controllers
{
    public class ProcessController : Controller
    {
        private readonly IProcessService _processService;

        public ProcessController(IProcessService processService)
        {
            _processService = processService;
        }

        public async Task<IActionResult> ProcessList()
        {
            var values = await _processService.TGetListAsync();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateProcess()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProcess(Rentaly.EntityLayer.Entities.Process process)
        {
            await _processService.TInsertAsync(process);
            return RedirectToAction("ProcessList");
        }
    }
}