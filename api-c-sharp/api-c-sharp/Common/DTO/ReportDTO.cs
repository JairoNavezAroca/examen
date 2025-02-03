namespace api_c_sharp.Common.DTO
{
    public class ReportDTO
    {
        public string NameUser { get; set; }
        public string EmailUser { get; set; }
        public int CountTransactions { get; set; }
        public decimal TotalAmountTransactions { get; set; }
    }
    public class ListReportDTO : List<ReportDTO>;
}
