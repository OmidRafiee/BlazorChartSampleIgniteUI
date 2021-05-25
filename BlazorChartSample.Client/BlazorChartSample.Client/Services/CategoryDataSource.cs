using System;
using System.Collections.Generic;
using BlazorChartSample.Client.ViewModel;

namespace BlazorChartSample.Client.Services
{
    public class CategoryDataItem
    {
        public string Label { get; set; }
        public double Value { get; set; }
    }

    public static class CategoryDataSource
    {
        public static List<CategoryDataItem> MappingToFHR1(this List<ExcelViewModel> model)
        {
            var data = new List<CategoryDataItem>();
            foreach (var item in model)
            {
                var timeStamp = UnixTimeStampToDateTime(item.timestamp).ToString();

                var i = new CategoryDataItem { Label = timeStamp, Value = item.FHR1 };

                data.Add(i);
            }

            return data;
        }
        public static List<CategoryDataItem> MappingToFHR2(this List<ExcelViewModel> model)
        {
            var data = new List<CategoryDataItem>();
            foreach (var item in model)
            {
                var timeStamp = UnixTimeStampToDateTime(item.timestamp).ToString();

                var i = new CategoryDataItem { Label = timeStamp, Value = item.FHR2 };

                data.Add(i);
            }

            return data;
        }
        public static List<CategoryDataItem> MappingToMHR(this List<ExcelViewModel> model)
        {
            var data = new List<CategoryDataItem>();
            foreach (var item in model)
            {
                var timeStamp = UnixTimeStampToDateTime(item.timestamp).ToString();

                var i = new CategoryDataItem { Label = timeStamp, Value = item.MHR };

                data.Add(i);
            }

            return data;
        }
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public static CategoryDataItem GetLastItem(IList<CategoryDataItem> array)
        {
            if (array.Count == 0)
            {
                return null;
            }
            return array[array.Count - 1];
        }

        public static CategoryDataItem GetNewItem(IList<CategoryDataItem> array)
        {
            var lastItem = GetLastItem(array);

            return lastItem;
        }

    }
}
