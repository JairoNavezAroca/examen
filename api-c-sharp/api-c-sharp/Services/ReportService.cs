using api_c_sharp.Common;
using api_c_sharp.Common.DTO;
using api_c_sharp.Infraestructure;
using System.Collections.Generic;

namespace api_c_sharp.Services
{
    public class ReportService : IReportService
    {
        private readonly ApiServiceController _apiServiceController;

        public ReportService(ApiServiceController apiServiceController)
        {
            _apiServiceController = apiServiceController;
        }

        public async Task<ResponseOperation<ListReportDTO>> GetReport()
        {
            ResponseOperation<ListReportDTO> response = new ResponseOperation<ListReportDTO>();
            response.Data = new ListReportDTO();
            List<UserDTO> userList;
            List<TransactionDTO> transactionList;
            try
            {
                userList = await _apiServiceController.GetUserList();
                transactionList = await _apiServiceController.GetTransactionList();
            }
            catch (Exception)
            {
                response.Success = false;
                response.Message = "Error al consultar a los servicios de Usuarios y/o Transacciones";
                return response;
            }

            foreach (var user in userList)
            {
                ReportDTO reportDTO = new ReportDTO() { 
                    NameUser  = user.Name,
                    EmailUser = user.Email,
                };
                reportDTO.CountTransactions = transactionList.Where(x => x.UserId == user.Id).Count();
                reportDTO.TotalAmountTransactions = transactionList.Where(x => x.UserId == user.Id).Sum(x => x.Amount);
                response.Data.Add(reportDTO);
            }

            response.Success = true;
            return response;
        }
    }
}
