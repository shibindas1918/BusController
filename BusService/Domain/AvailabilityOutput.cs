using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusService.Domain
{
    public class AvailabilityOutput
    {
        public List<Output_Result> Result { get; set; }

        public List<Error> Errors { get; set; }
    }

    public class Error
    {
        public string ErrorText { get; set; }
    }
    public class Output_Result
    {
        public string ratetypecd { get; set; }
        public string ratetypename { get; set; }
        public List<rateslots> rateslots { get; set; }
    }

    public class rateslots
    {
        public string min_buy { get; set; }
        public string max_buy { get; set; }
        public string availability { get; set; }
        public string time { get; set; }
        public List<rate> rate { get; set; }
    }

    public class rate
    {
        public string diff_name { get; set; }
        public string holder_code { get; set; }
        public string holder_code_id { get; set; }
        public string supp_diff_id { get; set; }
        public string min_buy { get; set; }
        public string max_buy { get; set; }
        public string availability { get; set; }
        public string currency { get; set; }
        public string value { get; set; }
        public string type { get; set; }
    }
}
