using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorChartSample.Client.Utils;
using BlazorChartSample.Client.ViewModel;

namespace BlazorChartSample.Client.Services
{
    public class ClientExcelService : IClientExcelService
    {
        private readonly HttpClient _httpClient;

        public ClientExcelService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ExcelViewModel>> GetDataAsync()
        {

            // How to url-encode query-string parameters properly
            var uri = new UriBuilderExt(new Uri(_httpClient.BaseAddress, "/api/excel/getDataList"))
             .Uri;

            var model = await _httpClient.GetFromJsonAsync<List<ExcelViewModel>>(uri);

            return model;
        }


    }
}
