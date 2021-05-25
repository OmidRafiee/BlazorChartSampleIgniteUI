using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorChartSample.WebApi.Service;
using BlazorChartSample.WebApi.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace BlazorChartSample.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExcelController : ControllerBase
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IExcelService _excelService;

        private readonly ILogger<ExcelController> _logger;

        public ExcelController(ILogger<ExcelController> logger, IExcelService excelService, IWebHostEnvironment hostingEnvironment)
        {
            _logger = logger;
            _excelService = excelService;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet("GetDataList")]
        public async Task<IActionResult> GetDataList()
        {
            var model = _excelService.GetDataList().Take(2000);
       

            return Ok(model);
        }
        
    }
}
