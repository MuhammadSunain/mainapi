using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class hdr_sm_batch
    {
        public int Id { get; internal set; }
        public string bookno { get; internal set; }
        public string bookdate { get; internal set; }
        public string booktype { get; internal set; }
        public string boojname { get; internal set; }
        public string status { get; internal set; }
        public string academicyearid { get; internal set; }
        public string startdate { get; internal set; }
        public string enddate { get; internal set; }
        public string prefix { get; internal set; }
        public string counter { get; internal set; }
        public string masklength { get; internal set; }
        public string totalseats { get; internal set; }
        public string enrolled { get; internal set; }
        public string available { get; internal set; }
    }
}