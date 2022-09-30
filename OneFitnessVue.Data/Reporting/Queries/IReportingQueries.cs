using System.Collections.Generic;
using OneFitnessVue.ViewModel.Reporting;

namespace OneFitnessVue.Data.Reporting.Queries
{
    public interface IReportingQueries
    {
        
        List<YearwiseChartResponseViewModel> YearwiseChartRenewedResponse();
        List<YearwiseChartResponseViewModel> YearwiseChartNewResponse();
        int? GetRenewedMonthlyCount();
        int? GetNewRegistrationMonthlyCount();
        List<MembershipTypeViewModel> GetTopMembershipTypeInYear();
        int? GetNewRegistrationDailyCount();
        int? GetRefundMonthlyCount();
    }
}