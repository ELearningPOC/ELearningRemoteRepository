//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ELearning.WebAPI.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class TenantMaster
    {
        public int ID { get; set; }
        public int TenantID { get; set; }
        public string TenantName { get; set; }
        public string DisplayName { get; set; }
        public Nullable<System.DateTime> ActivatedON { get; set; }
        public int LogoImageID { get; set; }
    }
}
