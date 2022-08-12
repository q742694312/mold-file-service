using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class CDrainPump
    {
        public int Id { get; set; }
        public string? CDraiPumpId { get; set; }
        public string? CSysId { get; set; }
        public string? CDraiPumpName { get; set; }
        public int CDraiPumpType { get; set; }
        public int CDraiPumpTypeFeat { get; set; }
        public string? CDraiPumpAdd { get; set; }
        public string? CDraiPumpPhone { get; set; }
        public string? CDraiPumpPostCode { get; set; }
        public int CNDraiPumpState { get; set; }
        public int CRingRoad { get; set; }
        public string? CDraiPumpComDsn { get; set; }
        public string? CDraiPumpComBuild { get; set; }
        public DateTime? CFinishDate { get; set; }
        public DateTime? CRunDate { get; set; }
        public DateTime? CReBuildDate { get; set; }
        public string? CDistrict { get; set; }
        public string? CTownowned { get; set; }
        public int CBuildyear { get; set; }
        public string? CInCom { get; set; }
        public DateTime? CInDate { get; set; }
        public string? CInUser { get; set; }
        public string? CVersionId { get; set; }
        public string? CRemark { get; set; }
        public int CKeyid { get; set; }
        public string? CUserId { get; set; }
        public string? CXtbm { get; set; }
        public string? CSysName { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public DateTime AddDate { get; set; }
    }
}
