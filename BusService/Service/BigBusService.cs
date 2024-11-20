using BusController.Domain;
using BusService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using Microsoft.Extensions.Logging;




namespace BusService.Service
{

    public class BigBusService : IBusService
    {
        private readonly ILogger<BigBusService> _logger;
        private readonly Config _configInfo;


        public BigBusService(ILogger<BigBusService> logger, Config config)
        {
            _logger = logger;
            _configInfo = config;

        }
        

        public class BigBusTourCA
        {
            public string productId { get; set; }
            public string localDate { get; set; }
            public List<_units_> units { get; set; }
        }
        public class _units_
        {
            public string id { get; set; }
            public string quantity { get; set; }
        }
        public async Task<TourOutput<TourAvailabilityOutput>> GetAvailabilityAsync(TourAvailabilityInput input)
        {
            TourAvailabilityOutput tourAvailabilityOutput = new TourAvailabilityOutput();
            var output = new TourOutput<TourAvailabilityOutput>();
            BigBusAvailabilityInput busAvailabilityInput = new BigBusAvailabilityInput();
            busAvailabilityInput = input.BigBusAvailabilityInput;
            output.LogItems = new List<ApiLogItem>();
            try
            {
                ApiRequest apiRequest = new ApiRequest();
             BigBusTourCA bigBusTourCA = new BigBusTourCA();
                List<_units_> _Units_s = new List<_units_>();
                bigBusTourCA.productId = busAvailabilityInput.ProductId;
                bigBusTourCA.units = _Units_s;
                output.LogItems.Add(new ApiLogItem() { Request = new ApiRequest { RequestType = ApiRequestTypes.ApiRequest, RequestStr = "availiablity" + JsonConvert.SerializeObject(bigBusTourCA), Logdt = DateTime.Now } });
                var result = await ExecuteBGApi<BigBusTourCA>("availablity", bigBusTourCA); //API call 
                result = result.ToString();
                List<BG_Result> resultList = new List<BG_Result>();
                if (result != null && !result.Contains('x'))
                {
                    BigBusAvailabilityOutput bigBusAvailabilityOutput = new BigBusAvailabilityOutput();
                    List<BigBusAvaiRes> bigBusAvaiRes = JsonConvert.DeserializeObject<List<BigBusAvaiRes>>(result);
                    if (bigBusAvaiRes.Count > 0)
                    {
                        foreach (var j in bigBusAvaiRes)
                        {
                            BG_Result bigBusResult = new BG_Result();
                            bigBusResult.Id = j.id.ToString();
                            bigBusResult.maxUnits = j.maxUnits.ToString();
                            List<unitPricing> unitPricingList = new List<unitPricing>();
                            foreach (var i in j.unitPricing)
                            {
                                unitPricing unitPricing = new unitPricing();
                                unitPricing.unitId = i.unitId.ToString();
                                unitPricingList.Add(unitPricing);
                            }
                            bigBusResult.unitPricing = unitPricingList;
                            resultList.Add(bigBusResult);
                        }

                    }
                    bigBusAvailabilityOutput.Result = resultList;
                    tourAvailabilityOutput.BigBusAvailabilityOutput = bigBusAvailabilityOutput; 
                    output.Result = tourAvailabilityOutput; 
                    output.Status = true;   
                }
                else
                {
                    tourAvailabilityOutput.BigBusAvailabilityOutput = new BigBusAvailabilityOutput() { Errors = new List<BG_Error> { new BG_Error { ErrorText = result } } };
                    output.Result = tourAvailabilityOutput;
                    output.Status = false;
                }
            }

            catch(Exception ex) 
            {
                this._logger.LogError(ex, $"Input: {JsonConvert.SerializeObject(input)}");
                output.LogItems.Add(new ApiLogItem() { Error = new ErrorLog { ErrorType = ErrorLogTypes.Exception, ErrorMessage = ex.Message, ErrorDetail = ex.ToString(), ErrorMethodName = "BigBusTourServices/GetAvailabilityAsync", Logdt = DateTime.Now } });
            }
            return await Task.FromResult<TourOutput<TourAvailabilityOutput>>(output);

            
        }

        // calling the bigbus supplier 

        /*Post Method to execute Bigbus API*/
        public async Task<string> ExecuteBGApi<T>(string url, T bigBusTourCA)
        {
            try
            {
                string result = "";
                using var client = new HttpClient();
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                client.DefaultRequestHeaders.Add("Octo-Capabilities", "octo/content");
                client.DefaultRequestHeaders.Add("Octo-Capabilities", "octo/pricing");
                client.DefaultRequestHeaders.Add("Octo-Capabilities", "octo/pickups");
                client.DefaultRequestHeaders.Add("Octo-Capabilities", "octo/offers");
                client.DefaultRequestHeaders.Add("Octo-Env", _configInfo.end_pnt_key2);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + _configInfo.end_pnt_key1);

                var json = System.Text.Json.JsonSerializer.Serialize(bigBusTourCA);
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(_configInfo.end_pnt_url + url, content);
                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    result = "×";
                    result += await response.Content.ReadAsStringAsync();
                }
                return result;
            }
            catch (Exception ex)
            {
                return "×" + ex.Message;
            }
        }
    }
}
