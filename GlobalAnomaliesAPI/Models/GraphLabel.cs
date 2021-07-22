using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobalAnomaliesAPI.Models
{
    /// <summary>
    /// This class represents the text of the labels for the GlobalAnomaliesAPI
    /// </summary>
    public class GraphLabel
    {
        public string title { get; }
        public string units { get; }
        public string base_period { get; }
        public int missing { get; }

        public GraphLabel()
        {
            title = "Global Land and Ocean Temperature Anomalies, October";
            units = "Degrees Celsius";
            base_period = "1901-2000";
            missing = -999;
        }        
        
    }
      
}