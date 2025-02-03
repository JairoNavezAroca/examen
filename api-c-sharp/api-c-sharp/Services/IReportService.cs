using api_c_sharp.Common;
using api_c_sharp.Common.DTO;

namespace api_c_sharp.Services
{
    public interface IReportService
    {
        Task<ResponseOperation<ListReportDTO>> GetReport();
    }
}
