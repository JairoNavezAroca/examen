using api_c_sharp.Common;
using api_c_sharp.Common.DTO;
using api_c_sharp.Services;
using Microsoft.AspNetCore.Mvc;

namespace api_c_sharp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("/report")]
        public async Task<IActionResult> GetReport()
        {
            ResponseOperation<ListReportDTO> response = await _reportService.GetReport();
            if (response.Success)
                return Ok(response.Data);
            else
                return StatusCode(503, response.Message);
        }
    }
}
