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
    
    public partial class FamilyInfo
    {
        public int Id { get; set; }
        public string RealName { get; set; }
        public string Sex { get; set; }
        public string IdCard { get; set; }
        public string BirthDay { get; set; }
        public bool HasBed { get; set; }
        public double Height { get; set; }
        public int EmpInfoId { get; set; }
        public bool IsTeacher { get; set; }
        public string LongTellNum { get; set; }
        public string ShortTellNum { get; set; }
    
        public virtual EmpInfo EmpInfo { get; set; }
    }
}
