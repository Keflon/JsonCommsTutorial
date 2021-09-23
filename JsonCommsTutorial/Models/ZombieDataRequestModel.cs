using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonCommsTutorial.Models
{
    public class ZombieDataRequestModel
    {
        public ZombieDataRequestModel(string regionCode, int requestedDetail)
        {
            RegionCode = regionCode;
            RequestedDetail = requestedDetail;
        }

        public string RegionCode { get; }
        public int RequestedDetail { get; }
    }
}
