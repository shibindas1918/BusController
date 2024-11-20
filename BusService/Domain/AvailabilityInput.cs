using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusService.Domain
{
    public class AvailabilityInput
    {
        public string Poscd { get; set; }
        public string SuppMapId { get; set; }
        public string SSMId { get; set; }
        public string ProductId { get; set; }
        public string? Pickupid { get; set; }
        public string Date { get; set; }
        public string? Language { get; set; }
        public string? Currency { get; set; }

    }
}
