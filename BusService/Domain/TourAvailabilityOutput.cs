using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusService.Domain
{
    public  class TourAvailabilityOutput
    {
        public AvailabilityOutput AvailabilityOutput { get; set; }
         public BigBusAvailabilityOutput BigBusAvailabilityOutput { get; set; } 
    }
}
