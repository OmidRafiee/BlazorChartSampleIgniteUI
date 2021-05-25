using System.Collections.Generic;
using BlazorChartSample.WebApi.ViewModel;

namespace BlazorChartSample.WebApi.Service
{
    public interface IExcelService
    {
        List<ExcelViewModel> GetDataList();

    }
}
