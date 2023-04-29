using System;

namespace ecmapi.Controllers.EntitySetup
{
    public class dtoentity
    {
        public int Id { get; internal set; }
        public string Code { get; internal set; }
        public string EntityName { get; internal set; }
        public DateTime? EntityDate { get; internal set; }
        public string EntityType { get; internal set; }
        public string ownerName { get; internal set; }
        public string contsctno { get; internal set; }
        public string email { get; internal set; }
        public string address { get; internal set; }
    }
}