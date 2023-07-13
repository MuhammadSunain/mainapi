using ecmapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class mstSM_MonthlyFees
    {
        public int Id { get; internal set; }
        public string course { get; internal set; }
        public string section { get; internal set; }
        public string month { get; internal set; }
        public string year { get; internal set; }
        public string duedate { get; internal set; }
        public string latefeeamount { get; internal set; }
        public int? entityId { get; internal set; }
        public int? clientId { get; internal set; }
        public IQueryable<mstSM_MonthlyFeeStudent_Detail> studentfeedetail { get; internal set; }
    }
}