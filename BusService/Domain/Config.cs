using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusService.Domain
{
    public class Config
    {
        public string supp_map_id { get; set; }
        public string end_pnt_nam { get; set; }
        public string end_pnt_url { get; set; }
        public string end_pnt_key1 { get; set; }
        public string end_pnt_key2 { get; set; }
        public string end_pnt_key3 { get; set; }
        public string end_pnt_key4 { get; set; }
        public string time_out { get; set; }
        public string aval_time_out { get; set; }
        public string end_pnt_vrsn { get; set; }
        public string end_pnt_crncy { get; set; }
        public string end_pnt_lang { get; set; }
        public string end_pnt_tkn { get; set; }
        public string tkn_url { get; set; }
        public string json_txt { get; set; }
        public string jrn_typ { get; set; }
        public int req_count { get; set; }
        public string api_gtwy_mode { get; set; }
        public string BasketId { get; set; }
        public string dflt_dlvry_typ { get; set; }
        public string email { get; set; }
        public string OfflnCnclPlcy { get; set; }
        public string OfflnCnclRfnd { get; set; }
        public string OnlnCnclPlcy { get; set; }
        public string pos_actv_end_pnt { get; set; }
        public string ubr_org_uuid { get; set; }
        public List<string> VehicleDetails { get; set; }
        public List<string> tui_extra_fld_excld_lst { get; set; }
        public string tui_extra_fld { get; set; }
        public string tui_extra_fld_excld { get; set; }
        public string DeliveryTypeId { get; set; }
    }
}
