﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbContainer : DbContext
    {
        public DbContainer()
            : base("name=DbContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TravelCategory> TravelCategory { get; set; }
        public virtual DbSet<TravelStage> TravelStage { get; set; }
        public virtual DbSet<EmpInfo> EmpInfo { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<FamilyInfo> FamilyInfo { get; set; }
        public virtual DbSet<TravelChoice> TravelChoice { get; set; }
        public virtual DbSet<AdminInfo> AdminInfo { get; set; }
        public virtual DbSet<FormNotice> FormNotice { get; set; }
        public virtual DbSet<ViewFinalStatistic> ViewFinalStatistic { get; set; }
    }
}
