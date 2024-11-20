using BusService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusService
{
    public  interface IBusService
    {
        Task<TourOutput<TourAvailabilityOutput>> GetAvailabilityAsync(TourAvailabilityInput input);
    }
}
