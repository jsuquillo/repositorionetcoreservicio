using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class PocPersonalData
    {
        public int PocPersonalDataId { get; set; }
        public string PocNames { get; set; }
        public string PocAge { get; set; }
        public string PocGender { get; set; }
        public string PocMaritalStatus { get; set; }
        public string PocProfession { get; set; }
        public string PocDescription { get; set; }
        public string PocNationality { get; set; }
        public string PocFeelings { get; set; }
    }
}
