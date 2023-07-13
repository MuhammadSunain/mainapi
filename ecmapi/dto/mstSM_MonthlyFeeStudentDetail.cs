using ecmapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecmapi.dto
{
    public class mstSM_MonthlyFeeStudentDetail
    {
        public int? monthfeeid { get; internal set; }
        public string stdid { get; internal set; }
        public string grno { get; internal set; }
        public string stdname { get; internal set; }
        public string fathername { get; internal set; }
        public string course { get; internal set; }
        public string section { get; internal set; }
        public string monthlyfee { get; internal set; }
        public string dis_amount { get; internal set; }
        public int? entityId { get; internal set; }
        public string clientId { get; internal set; }
        public int Id { get; internal set; }
        public IQueryable<mstSM_MonthlyFee> monthfee { get; internal set; }
        internal IQueryable<mstSM_MonthlyFee> total { get; set; }
    }
}