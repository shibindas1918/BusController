using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusService.Domain
{
     public class BigBusAvailability
    {
        public List<BigBusAvaiRes> BigBusAvaiRes { get; set; }
    }

    public class BigBusAvaiRes
    {
        public string id { get; set; }
        public string localDateTimeStart { get; set; }
        public string localDateTimeEnd { get; set; }
        public bool allDay { get; set; }
        public bool available { get; set; }
        public string status { get; set; }
        public string vacancies { get; set; }
        public string capacity { get; set; }
        public int? paxCount { get; set; }
        public int? maxUnits { get; set; }
        public int? maxPaxCount { get; set; }
        public string utcCutoffAt { get; set; }
        public List<openingHours> openingHours { get; set; }
        public string meetingPoint { get; set; }
        public string meetingPointCoordinates { get; set; }
        public string meetingPointLatitude { get; set; }
        public string meetingPointLongitude { get; set; }]
        public string meetingLocalDateTime { get; set; }
        public string tourGroup { get; set; }
        public List<notices> notices { get; set; }
        public List<_unitPricing_> unitPricing { get; set; }
        public _Pricing_ _Pricing_ { get; set; }
        public List<offers> offers { get; set; }
        public string offerCode { get; set; }
        public string offerTitle { get; set; }
        public offers offer { get; set; }
        public bool pickupAvailable { get; set; }
        public bool pickupRequired { get; set; }
        public List<string> pickupPoints { get; set; }
    }

    public class openingHours
    {
        public string from { get; set; }
        public string to { get; set; }
        public string frequency { get; set; }
        public string frequencyAmount { get; set; }
        public string frequencyUnit { get; set; }
    }

    public class notices
    {
        public string id { get; set; }
        public string title { get; set; }
        public string shortDescription { get; set; }
        public string coverImageUrl { get; set; }
    }

    public class _unitPricing_
    {
        public string unitId { get; set; }
        public int original { get; set; }
        public int retail { get; set; }
        public int net { get; set; }
        public string currency { get; set; }
        public int currencyPrecision { get; set; }
        public List<includedTaxes> includedTaxes { get; set; }
        public offerDiscount offerDiscount { get; set; }
    }
    
    public class _Pricing_
    {
        public int original { get; set; }
        public int retail { get; set; }
        public int net { get; set; }
        public List<string> includedTaxes { get; set; }
        public offerDiscount offerDiscount { get; set; }
        public string currency { get; set; }
        public int currencyPrecision { get; set; }
    }

    public class offerDiscount
    {
        public string retail { get; set; }
        public string net { get; set; }
        public List<includedTaxes> includedTaxes { get; set; }
    }

    public class offers
    {
        public string title { get; set; }
        public string label { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public string netDiscount { get; set; }
        public restrictions restrictions { get; set; }
        public bool usable { get; set; }
        public string unusableReason { get; set; }
    }

    public class restrictions
    {
        public int? minUnits { get; set; }
        public int? maxUnits { get; set; }
        public int? minTotal { get; set; }
        public int? maxTotal { get; set; }
        public List<string> unitIds { get; set; }
    }
    public class includedTaxes
    {
        public string name { get; set; }
        public int? original { get; set; }
        public int? retail { get; set; }
        public int? net { get; set; }
    }
}
