//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TravelChoice
    {
        public int Id { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int TravelCategoryId { get; set; }
        public int TravelStageId { get; set; }
    
        public virtual TravelCategory TravelCategory { get; set; }
        public virtual TravelStage TravelStage { get; set; }
        public virtual EmpInfo EmpInfo { get; set; }
    }
}
