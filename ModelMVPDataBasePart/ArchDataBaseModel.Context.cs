﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelMVPDataBasePart
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ArcheageDataBaseEntities : DbContext
    {
        public ArcheageDataBaseEntities()
            : base("name=ArcheageDataBaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EventBase> EventBase { get; set; }
        public virtual DbSet<EventTimeTable> EventTimeTable { get; set; }
    
        public virtual int CheckUser(ObjectParameter inResulter, string inName, string inPass)
        {
            var inNameParameter = inName != null ?
                new ObjectParameter("InName", inName) :
                new ObjectParameter("InName", typeof(string));
    
            var inPassParameter = inPass != null ?
                new ObjectParameter("InPass", inPass) :
                new ObjectParameter("InPass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CheckUser", inResulter, inNameParameter, inPassParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetNowUserID()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetNowUserID");
        }
    }
}
