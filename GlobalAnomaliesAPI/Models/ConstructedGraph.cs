using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobalAnomaliesAPI.Models
{
    public class ConstructedGraph
    {

        public ConstructedGraph()
        {
            description = new GraphLabel();
            data = new GraphData().GetFillData();
        }

        public GraphLabel  description {get;}
        public Dictionary <string, string> data { get; }
    }
}