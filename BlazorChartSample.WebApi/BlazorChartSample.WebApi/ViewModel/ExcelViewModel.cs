using CsvHelper.Configuration.Attributes;

namespace BlazorChartSample.WebApi.ViewModel
{
    public class ExcelViewModel
    {
        [Index(0)]
        public string id { get; set; }
        [Index(1)]
        public string time_offset { get; set; }
        [Index(2)]
        public double MHR { get; set; }
        
        [Index(3)]
        public double FHR1 { get; set; }
        [Index(4)]
        public double FHR2 { get; set; }
        [Index(5)]
        public string FHR3 { get; set; }
        [Index(6)]
        public string[] modes { get; set; }
        [Index(7)]
        public string TOCO { get; set; }
        [Index(8)]
        public string QUALITY1 { get; set; }
        [Index(9)]
        public string QUALITY2 { get; set; }
        [Index(10)]
        public string QUALITY3 { get; set; }
        [Index(11)]
        public string MQUALITY { get; set; }
        [Index(12)]
        public double timestamp { get; set; }
        [Index(13)]
        public string MOVEMENT { get; set; }
        [Index(14)]
        public string NOTE { get; set; }
        [Index(15)]
        public string MARKER { get; set; }
        [Index(16)]
        public string ALARMACK { get; set; }
        [Index(17)]
        public string SPEED { get; set; }
        [Index(18)]
        public string RR { get; set; }
        [Index(19)]
        public string SPO2 { get; set; }
        [Index(20)]
        public string TEMP { get; set; }
    }
}
