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
    
    public partial class CourseBookmark
    {
        public int ID { get; set; }
        public int TenantID { get; set; }
        public int CourseID { get; set; }
        public int ChapterID { get; set; }
        public Nullable<int> ChapterContentID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> BookmarkStatus { get; set; }
    }
}
