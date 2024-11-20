using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusService.Domain
{
    public class BigBusAvailabilityOutput
    {
        public List<BG_Result> Result { get; set; }
        public List<BG_Error> Errors { get; set; }
    }

    public class BG_Error
    {
        public string ErrorText { get; set; }
    }

    public class BG_Result
    {
        public string Id { get; set; }
        public string maxUnits { get; set; }
        public List<unitPricing> unitPricing { get; set; }
    }

    public class unitPricing
    {
        public string unitId { get; set; }
        public string RetailPrice { get; set; }
    }
}
