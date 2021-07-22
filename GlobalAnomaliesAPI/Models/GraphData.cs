using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobalAnomaliesAPI.Models
{
    /// <summary>
    /// This graph represents the global land/water anomalies
    /// </summary>
    public class GraphData
    {
        public Dictionary<string, string> data { get; }
        

        /// <summary>
        /// Returns the data for the Global Anomalie graph
        /// </summary>
        /// <returns>Dictionary<string, string></returns>
        public Dictionary<string, string> GetFillData()
        {
            return new Dictionary<string, string>()
            {
                { "1901", "-0.24" },
                { "1902", "-0.30" },
                { "1903", "-0.23" },
                { "1904", "-0.22" },
                { "1905", "-0.22" },
                { "1906", "-0.24" },
                { "1907", "-0.26" },
                { "1908", "-0.21" },
                { "1909", "-0.20" },
                { "1910", "0.22" },
                { "1911", "-0.27" },
                { "1912", "-0.29" },
                { "1913", "-0.25" }
            };
        }
    }
}