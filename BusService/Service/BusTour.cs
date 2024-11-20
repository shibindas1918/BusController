using BusController.Domain;
using BusService.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusService.Service
{
    public class BusTour : IBusService
    {
        public Task<TourOutput<TourAvailabilityOutput>> GetAvailabilityAsync(TourAvailabilityInput input)
        {
            TourAvailabilityOutput tourAvailabilityOutput = new TourAvailabilityOutput();
            var output = new TourOutput<TourAvailabilityOutput>();
            BigBusAvailabilityInput bigBusAvailabilityInput = new BigBusAvailabilityInput();
            bigBusAvailabilityInput = input.BigBusAvailabilityInput;
            output.LogItems = new List<ApiLogItem>();
            try
            {
              ApiRequest apiRequest = new ApiRequest();
                apiRequest.Logdt= DateTime.Now;
                apiRequest.RequestStr = "Shibin";
                apiRequest.RequestType= 
              output.LogItems.Add(new ApiLogItem() {Request = new ApiRequest {RequestType = ApiRequestTypes.ApiRequest, RequestStr= "availiablity"+ JsonConvert.SerializeObject(input) }} }  
               


            }
            catch (Exception ex)
            {
            }

            throw new NotImplementedException();
        }
    }
}
