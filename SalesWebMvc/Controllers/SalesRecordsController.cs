using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly SalesRecordService _salesRecordService;

        public SalesRecordsController(SalesRecordService salesRecordService)
        {
            _salesRecordService = salesRecordService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> SimpleSearch(DateTime? mindate, DateTime? maxdate)
        {
            var result = await _salesRecordService.FindByDateAsync(mindate, maxdate);
            
            return View(result);
        }
        public IActionResult GroupingSearch()
        {
            return View();
        }
    }
}
