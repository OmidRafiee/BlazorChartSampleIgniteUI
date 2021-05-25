using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using BlazorChartSample.WebApi.ViewModel;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Hosting;

namespace BlazorChartSample.WebApi.Service
{
    public class ExcelService : IExcelService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ExcelService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public List<ExcelViewModel> GetDataList()
        {
            var path = Path.Combine(_hostingEnvironment.WebRootPath + @"\DataExcel.csv");
            var records = new List<ExcelViewModel>();

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";",
                PrepareHeaderForMatch = args => args.Header.ToLower(),

            };

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, config))
            {
                records = csv.GetRecords<ExcelViewModel>().ToList();
            }

            return records;
        }

     
    }
}
