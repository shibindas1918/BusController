using BusController.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusService.Domain
{
    public  class TourOutput<T>
    {
       public List<ApiLogItem> LogItems { get; set; }
        public bool Status { get; set; }    
        public T Result { get; set; }   

    }
}
