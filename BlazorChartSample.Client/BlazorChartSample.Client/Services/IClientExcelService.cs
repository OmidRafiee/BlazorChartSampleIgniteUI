using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorChartSample.Client.ViewModel;

namespace BlazorChartSample.Client.Services
{
    public interface IClientExcelService
    {
        public Task<List<ExcelViewModel>> GetDataAsync();

    }
}
